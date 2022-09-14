using _0_Framework.Application;
using Haidarieh.Application.Contracts.Ceremony;
using Haidarieh.Domain.CalendarAgg;
using Haidarieh.Domain.CeremonyAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haidarieh.Application
{
    public class CeremonyApplication : ICeremonyApplication
    {
        private readonly ICeremonyRepository _ceremonyRepository;
        private readonly ICalendarRepository _calendarRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IAuthHelper AuthHelper;
        public Ceremony ceremony { get; set; }
        public CeremonyApplication(ICeremonyRepository ceremonyRepository, IFileUploader fileUploader, IAuthHelper authHelper, ICalendarRepository calendarRepository)
        {
            _ceremonyRepository = ceremonyRepository;
            _fileUploader = fileUploader;
            AuthHelper = authHelper;
            _calendarRepository = calendarRepository;
        }

        public OperationResult Create(CreateCeremony command)
        {
            var operation = new OperationResult();
          
            var calendar = _calendarRepository.GetDetail(command.CalendarId);

            string SubString = command.CeremonyDate.Substring(0,4);

            //if (_ceremonyRepository.Exist(x => x.CalendarId == command.CalendarId && x.CeremonyDate.ToFarsi().Substring(0, 4) == command.CeremonyDate))
            //    return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var title = calendar.Title +" "+ SubString;
            var slug = command.Slug.Slugify();

            var ImageFolderName = Tools.ToFolderName(this.GetType().Name);
            var ImagePath = $"{ImageFolderName}/{command.Slug}";
            var imageFileName = _fileUploader.Upload(command.Image, ImagePath).savePath;
            var bannerFileName = _fileUploader.Upload(command.BannerFile, ImagePath).savePath;

            ceremony = new Ceremony(title, command.CeremonyDate.ToGeorgianDateTime(), command.IsLive, bannerFileName, 
                imageFileName, command.ImageAlt, command.ImageTitle, command.Keywords, command.MetaDescription, slug,command.CalendarId);
            _ceremonyRepository.Create(ceremony);   
            _ceremonyRepository.SaveChanges();
            CreateOperationLog(ceremony.Id, 1);
            return operation.Succedded();
        }

        public OperationResult CreateOperationLog(long id, int operationType)
        {
            var operation = new OperationResult();
            var currentAccount = AuthHelper.CurrentUserInfo();

            //var ceremony = _ceremonyRepository.Get(id);
            //var cer = new CeremonyOperation(operationType, 78, "Description", id);
            //if (ceremony == null)
            //    return operation.Failed(ApplicationMessages.RecordNotFound);
            ceremony.CreateOperationLog(operationType, currentAccount.Id, "ندارد", id);
            _ceremonyRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditCeremony command)
        {
            var operation = new OperationResult();
            operation.IsSuccedded = false;
            ceremony = _ceremonyRepository.Get(command.Id);
            if (ceremony == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if(_ceremonyRepository.Exist(x=>x.Title==command.Title && x.Id!=command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();

            var ImageFolderName = Tools.ToFolderName(this.GetType().Name);
            var ImagePath = $"{ImageFolderName}/{command.Slug}";
            var imageFileName = _fileUploader.Upload(command.Image, ImagePath).savePath;
            var bannerFileName = _fileUploader.Upload(command.BannerFile, ImagePath).savePath;

            ceremony.Edit(command.Title, command.CeremonyDate.ToGeorgianDateTime(), command.IsLive, bannerFileName,
                imageFileName, command.ImageAlt, command.ImageTitle, command.Keywords, command.MetaDescription, slug,command.CalendarId);
            
            _ceremonyRepository.SaveChanges();
            CreateOperationLog(ceremony.Id, 2);
            return operation.Succedded();
        }

        public List<CeremonyViewModel> GetCeremonies()
        {
            return _ceremonyRepository.GetCeremonies();
        }

        public List<CeremonyOperationViewModel> GetCeremonyWithOperationsLog()
        {
            return _ceremonyRepository.GetCeremonyWithOperationsLog();
        }

        public EditCeremony GetDetail(long Id)
        {
            return _ceremonyRepository.GetDetail(Id);
        }

        public List<CeremonyViewModel> Search(CeremonySearchModel searchModel)
        {
            return _ceremonyRepository.Search(searchModel);
        }

        public List<CeremonyViewModel> GetUpcommingCeremonies()
        {
            return _ceremonyRepository.GetUpcommingCeremonies();
        }

        public List<CeremonyViewModel> GetCeremonieswithGuests()
        {
            return _ceremonyRepository.GetCeremonieswithGuests();
        }
    }
}
