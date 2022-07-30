using _0_Framework.Application;
using _01_HaidariehQuery.Contracts.Ceremonies;
using _01_HaidariehQuery.Contracts.CeremonyGuests;
using _01_HaidariehQuery.Contracts.Multimedias;
using Haidarieh.Application.Contracts.Guest;
using Haidarieh.Domain.CeremonyGuestAgg;
using Haidarieh.Domain.GuestAgg;
using Haidarieh.Domain.MultimediaAgg;
using Haidarieh.Infrastructure.EFCore;
using Microsoft.AspNetCore.Razor.CodeGenerators;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace _01_HaidariehQuery.Query
{
    public class CeremonyQuery : ICeremonyQuery
    {
        private readonly HContext _hContext;

        public CeremonyQuery(HContext hContext)
        {
            _hContext = hContext;
        }

        public List<CeremonyQueryModel> GetCeremonies()
        {
            return _hContext.Ceremonies.Where(x => x.Status == true).Select(x => new CeremonyQueryModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                Status = x.Status
            }).ToList();
        }

        public List<CeremonyQueryModel> GetComing()
        {
            return _hContext.CeremonyGuests.Include(x => x.Ceremony)
                                                .Where(x => x.Ceremony.Status == true &&
                                                DateTime.Now.Date <= x.Ceremony.CeremonyDate.Date &&
                                                DateTime.Compare(x.Ceremony.CeremonyDate.AddHours(4), DateTime.Now) > 0)
                                                .Select(x => new CeremonyQueryModel
                                                {
                                                    Id = x.Ceremony.Id,
                                                    Title = x.Ceremony.Title,
                                                    CeremonyDateFa = x.Ceremony.CeremonyDate.ToFarsi(),
                                                    CeremonyTime = x.Ceremony.CeremonyDate.ToString("HH:mm"),
                                                    CeremonyDate = x.Ceremony.CeremonyDate,
                                                    Image = x.Ceremony.Image,
                                                    ImageAlt = x.Ceremony.ImageAlt,
                                                    ImageTitle = x.Ceremony.ImageTitle,
                                                    IsLive = x.Ceremony.IsLive,
                                                    BannerFile = x.Ceremony.BannerFile,
                                                    Slug = x.Ceremony.Slug,
                                                    Keywords = x.Ceremony.Keywords,
                                                    MetaDescription = x.Ceremony.MetaDescription
                                                }).AsNoTracking().Take(3).Distinct().ToList();
            //query = query.Include(x => x.CeremonyGuests.Where(z => z.CeremonyId == x.Id));
            //return query.ToList();

        }
        public List<CeremonyQueryModel> GetPast()
        {
            var pastlist = _hContext.CeremonyGuests.Include(x => x.Ceremony).
                                            Where(x => x.Ceremony.Status == true &&
                                            x.Ceremony.CeremonyDate.Date <= DateTime.Now.Date &&
                                            DateTime.Compare(x.Ceremony.CeremonyDate.AddHours(4), DateTime.Now) < 0).
                                            Select(x => new CeremonyQueryModel
                                            {
                                                Id = x.Ceremony.Id,
                                                Title = x.Ceremony.Title,
                                                CeremonyDateFa = x.Ceremony.CeremonyDate.ToFarsi(),
                                                CeremonyDate = x.Ceremony.CeremonyDate,
                                                Image = x.Ceremony.Image,
                                                ImageAlt = x.Ceremony.ImageAlt,
                                                ImageTitle = x.Ceremony.ImageTitle,
                                                IsLive = x.Ceremony.IsLive,
                                                BannerFile = x.Ceremony.BannerFile,
                                                Slug = x.Ceremony.Slug,
                                                Keywords = x.Ceremony.Keywords,
                                                MetaDescription = x.Ceremony.MetaDescription
                                            }).AsNoTracking().Distinct().Take(6).ToList();
            return pastlist;
        }
        public List<CeremonyQueryModel> GetAll()
        {
            return _hContext.CeremonyGuests.Where(x => x.Ceremony.Status == true).Select(x => new CeremonyQueryModel
            {
                Id = x.Id,
                Title = x.Ceremony.Title,
                CeremonyDateFa = x.Ceremony.CeremonyDate.ToFarsi(),
                CeremonyDate = x.Ceremony.CeremonyDate,
                Image = x.Ceremony.Image,
                ImageAlt = x.Ceremony.ImageAlt,
                ImageTitle = x.Ceremony.ImageTitle,
                IsLive = x.Ceremony.IsLive,
                BannerFile = x.Ceremony.BannerFile,
                Slug = x.Ceremony.Slug,
                Keywords = x.Ceremony.Keywords,
                MetaDescription = x.Ceremony.MetaDescription
            }).AsNoTracking().ToList();

        }

        public List<CeremonyQueryModel> GetCeremonyWithMultimedias()
        {
            return _hContext.Ceremonies.Include(x => x.Multimedias).
                                            Include(x => x.CeremonyGuests).
                                            ThenInclude(x => x.Guest).
                                            Where(x => x.Status == true).Select(x => new CeremonyQueryModel
                                            {
                                                Id = x.Id,
                                                Title = x.Title,
                                                CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                                                CeremonyDate = x.CeremonyDate,
                                                Image = x.Image,
                                                ImageAlt = x.ImageAlt,
                                                ImageTitle = x.ImageTitle,
                                                IsLive = x.IsLive,
                                                BannerFile = x.BannerFile,
                                                Slug = x.Slug,
                                                Keywords = x.Keywords,
                                                MetaDescription = x.MetaDescription,
                                                CeremonyGuests = MapCeremonyGuests(x.CeremonyGuests),
                                                Multimedias = MapMultimedias(x.Multimedias, 0)

                                            }).AsNoTracking().ToList();
        }

        private static List<MultimediaQueryModel> MapMultimedias(List<Multimedia> multimedias, int typeId)
        {
            string contentType;
            
            //var x = contentType;
            var medias = multimedias.Where(x => x.Status == true).Select(x => new MultimediaQueryModel

            {
                Id = x.Id,
                Title = x.Title,
                FileAddress = x.FileAddress,
                FileAlt = x.FileAlt,
                FileTitle = x.FileTitle

        }).ToList();
            foreach (var item in medias)
            {
                new FileExtensionContentTypeProvider().TryGetContentType(item.FileAddress, out contentType);
                var x = contentType;
                item.ContentType = x;
            }

            if (typeId == 1)
            {

                medias = medias.Where(x => x.ContentType.StartsWith("image/")).ToList();
            }
            else if (typeId == 2)
            {

                medias = medias.Where(x => x.ContentType.StartsWith("audio/")).ToList();
            }
            else if (typeId == 3)
            {

                medias = medias.Where(x => x.ContentType.StartsWith("video/")).ToList();
            }

            return medias.ToList();
        }

        private static List<CeremonyGuestQueryModel> MapCeremonyGuests(List<CeremonyGuest> ceremonyGuests)
        {

            return ceremonyGuests.Select(x => new CeremonyGuestQueryModel
            {
                Id = x.Id,
                CeremonyId = x.CeremonyId,
                GuestId = x.GuestId,
                Guest = x.Guest.FullName,
                GuestType = GuestTypes.GetGuestType(x.Guest.GuestType)

            }).ToList();
        }

        public CeremonyQueryModel GetCeremonyWithMultimedias(string id=null, int typeId = 0)
        {
            var ceremonies = _hContext.Ceremonies.Include(x => x.CeremonyGuests).
                                            ThenInclude(x => x.Guest).
                                            Where(x => x.Status == true).Select(x => new CeremonyQueryModel
                                            {
                                                Id = x.Id,
                                                Title = x.Title,
                                                CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                                                CeremonyDate = x.CeremonyDate,
                                                Image = x.Image,
                                                ImageAlt = x.ImageAlt,
                                                ImageTitle = x.ImageTitle,
                                                IsLive = x.IsLive,
                                                BannerFile = x.BannerFile,
                                                Slug = x.Slug,
                                                Keywords = x.Keywords,
                                                MetaDescription = x.MetaDescription,
                                                CeremonyGuests = MapCeremonyGuests(x.CeremonyGuests),
                                                Multimedias = MapMultimedias(x.Multimedias, typeId)
                                            }).AsNoTracking().FirstOrDefault(x => x.Slug == id);

            return ceremonies;
        }

        public List<CeremonyQueryModel> Search(string phrase)
        {
            var query = _hContext.Ceremonies.Where(x => x.Status == true).Select(x => new CeremonyQueryModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                CeremonyDate = x.CeremonyDate,
                Image = x.Image,
                ImageAlt = x.ImageAlt,
                ImageTitle = x.ImageTitle,
                IsLive = x.IsLive,
                BannerFile = x.BannerFile,
                Slug = x.Slug,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                CeremonyGuests = MapCeremonyGuests(x.CeremonyGuests),
                Multimedias = MapMultimedias(x.Multimedias, 0)
            }).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(phrase))
                query = query.Where(x => x.Title.Contains(phrase));
            var result = query.OrderByDescending(x => x.Id).ToList();
            return result;
        }


        public List<CeremonyQueryModel> GetAllCeremonyWithMultimedias()
        {
            var ceremonies = _hContext.Ceremonies.Include(x => x.CeremonyGuests).
                                            ThenInclude(x => x.Guest).
                                            Where(x => x.Status == true).Select(x => new CeremonyQueryModel
                                            {
                                                Id = x.Id,
                                                Title = x.Title,
                                                CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                                                CeremonyDate = x.CeremonyDate,
                                                Image = x.Image,
                                                ImageAlt = x.ImageAlt,
                                                ImageTitle = x.ImageTitle,
                                                IsLive = x.IsLive,
                                                BannerFile = x.BannerFile,
                                                Slug = x.Slug,
                                                Keywords = x.Keywords,
                                                MetaDescription = x.MetaDescription,
                                                CeremonyGuests = MapCeremonyGuests(x.CeremonyGuests),
                                                Multimedias = MapMultimedias(x.Multimedias, 0)
                                            }).AsNoTracking().ToList();
            return ceremonies;
        }




        //---------------------
        //public List<CeremonyGuestQueryModel> GetCeremonyGuestWithMultimedias2(string id)
        //{
        //    return _hContext.CeremonyGuests.Include(x => x.Multimedias).
        //                                    ThenInclude(x => x.CeremonyGuest).
        //                                    ThenInclude(x => x.Guest).
        //                                    Where(x => x.Status == true && x.Slug == id).Select(x => new CeremonyGuestQueryModel
        //                                    {
        //                                        Id = x.Id,
        //                                        //Ceremony = x.Ceremony.Title,
        //                                        //CeremonyDateFa = x.CeremonyDate.ToFarsi(),
        //                                        Guest = x.Guest.FullName,
        //                                        Slug = x.Slug,
        //                                        Multimedias = MapMultimedias(x.Multimedias)
        //                                    }).AsNoTracking().ToList();
        //}

        //public List<CeremonyGuestQueryModel> GetCeremonyGuestWithMultimedias2(long id)
        //{
        //    var ceremonyGuest = _hContext.CeremonyGuests.Include(x => x.Guest).
        //                                    Include(x => x.Multimedias).
        //                                    ThenInclude(x => x.CeremonyGuest).
        //                                    ThenInclude(x => x.Ceremony).
        //                                    Where(x => x.Status == true && x.CeremonyId == id).Select(x => new CeremonyGuestQueryModel
        //                                    {
        //                                        Id = x.Id,
        //                                        Ceremony = x.Ceremony.Title,
        //                                        CeremonyDateFa = x.CeremonyDate.Date.ToFarsi(),
        //                                        Guest = x.Guest.FullName,
        //                                        Slug = x.Slug,
        //                                        Multimedias = MapMultimedias(x.Multimedias)
        //                                    }).AsNoTracking().ToList();
        //    return ceremonyGuest;
        //}
    }
}





