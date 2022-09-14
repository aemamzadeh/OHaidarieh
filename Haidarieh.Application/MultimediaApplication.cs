using _0_Framework.Application;
using Haidarieh.Application.Contracts.Multimedia;
using Haidarieh.Domain.CeremonyAgg;
using Haidarieh.Domain.MultimediaAgg;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;

namespace Haidarieh.Application
{
    public class MultimediaApplication : IMultimediaApplication
    {
        private readonly IMultimediaRepository _multimediaRepository;
        private readonly ICeremonyRepository _ceremonyRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IImageCompression _imageCompression;

        public MultimediaApplication(IMultimediaRepository multimediaRepository, ICeremonyRepository ceremonyRepository, IFileUploader fileUploader, IImageCompression imageCompression)
        {
            _multimediaRepository = multimediaRepository;
            _ceremonyRepository = ceremonyRepository;
            _fileUploader = fileUploader;
            _imageCompression = imageCompression;
        }
        public OperationResult Create(CreateMultimedia command, List<IFormFile> files)
        {
            var operation= new OperationResult();
            if(_multimediaRepository.Exist(x=>x.Title==command.Title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var ceremony = _ceremonyRepository.GetDetail(command.CeremonyId);
            foreach (var item in files)
            {
                var ImageFolderName = Tools.ToFolderName(this.GetType().Name);
                var ImagePath = $"{ImageFolderName}/{ceremony.Slug}";
                var imageFileName = _fileUploader.Upload(item, ImagePath);
                var filePath = _fileUploader.Upload(item, ImagePath).filePath;

                if (item.ContentType.StartsWith("image/"))
                {
                    _imageCompression.ImageOptimize(item,imageFileName.filePath);
                    if (Image.FromFile(filePath).Width > 800 && Image.FromFile(filePath).Height > 600)
                        File.Delete(filePath);
                }
                var multimedia = new Multimedia(ceremony.Title, imageFileName.savePath, command.FileTitle, command.FileAlt, command.CeremonyId,command.VisitCount,command.GuestId);
                _multimediaRepository.Create(multimedia);
            }


            _multimediaRepository.SaveChanges();
            return operation.Succedded();
        }


        public OperationResult EditAlbum(EditMultimedia command, List<IFormFile> files)
        {
            var operation = new OperationResult();
            operation.IsSuccedded = false;
            var editItem = _multimediaRepository.GetFirst(command.CeremonyId);
            if (editItem == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            //if(_multimediaRepository.Exist(x=>x.Title==x.Title && x.Id!=command.Id))
            //    return operation.Failed(ApplicationMessages.DuplicatedRecord);
            foreach (var item in files)
            {
                var ceremony = _ceremonyRepository.GetDetail(command.CeremonyId);
                var ImageFolderName = Tools.ToFolderName(this.GetType().Name);
                var ImagePath = $"{ImageFolderName}/{ceremony.Slug}";
                var imageFileName = _fileUploader.Upload(item, ImagePath);
                var filePath = _fileUploader.Upload(item, ImagePath).filePath;

                if (item.ContentType.StartsWith("image/"))
                {
                    _imageCompression.ImageOptimize(item, filePath);
                    if (Image.FromFile(filePath).Width > 800 && Image.FromFile(filePath).Height > 600)
                        File.Delete(filePath);
                }
                //var imageFileName = _fileUploader.Upload(item, ImagePath);
                //editItem.EditAlbum(imageFileName.savePath, command.CeremonyId,command.GuestId,editItem.FileTitle,editItem.FileAlt);
                var multimedia = new Multimedia(ceremony.Title, imageFileName.savePath, editItem.FileTitle, editItem.FileAlt, command.CeremonyId, command.VisitCount,command.GuestId);
                _multimediaRepository.Create(multimedia);

            }
            _multimediaRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditMultimedia GetDetail(long Id)
        {
            return _multimediaRepository.GetDetail(Id);
        }
        public EditMultimedia GetDetailMultimedia(long Id)
        {
            return _multimediaRepository.GetDetailMultimedia(Id);
        }

        public OperationResult EditMetadata(EditMultimedia command)
        {
            var operation = new OperationResult();
            operation.IsSuccedded = false;
            var editItem = _multimediaRepository.GetList(command.CeremonyId);
            if (editItem == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            //if (_multimediaRepository.Exist(x => x.Title == x.Title && x.Id != command.Id))
            //    return operation.Failed(ApplicationMessages.DuplicatedRecord);
            foreach (var item in editItem)
            {
                item.EditMetadata(command.Title, command.FileTitle, command.FileAlt, command.CeremonyId);
            }
            _multimediaRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<MultimediaViewModel> GetMultimediasWithCeremony(long id)
        {
            return _multimediaRepository.GetMultimediasWithCeremony(id);
        }

        public List<MultimediaViewModel> Search(MultimediaSearchModel searchModel)
        {
            return _multimediaRepository.Search(searchModel);
        }

        public OperationResult Delete(long command)
        {
            var operation = new OperationResult();
            operation.IsSuccedded = false;
            var deleteItem = _multimediaRepository.Get(command);
            if (deleteItem == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            deleteItem.Delete();
            _multimediaRepository.SaveChanges();
            return operation.Succedded();
        }

        public long AddVisitCount(long Id)
        {
            var editItem = _multimediaRepository.Get(Id);
            editItem.Edit(editItem.Title, editItem.FileAddress,editItem.FileTitle, editItem.FileAlt, editItem.CeremonyId, editItem.VisitCount+1,editItem.GuestId);
            _multimediaRepository.SaveChanges();
            var ret = editItem.VisitCount;
            return ret;
        }
    }
}
