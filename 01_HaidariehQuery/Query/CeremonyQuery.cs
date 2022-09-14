using _0_Framework.Application;
using _01_HaidariehQuery.Contracts.Ceremonies;
using _01_HaidariehQuery.Contracts.CeremonyGuests;
using _01_HaidariehQuery.Contracts.Multimedias;
using Haidarieh.Application.Contracts.Guest;
using Haidarieh.Domain.CeremonyAgg;
using Haidarieh.Domain.CeremonyGuestAgg;
using Haidarieh.Domain.GuestAgg;
using Haidarieh.Domain.MultimediaAgg;
using Haidarieh.Infrastructure.EFCore;
using LinqKit;
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
                CeremonyDate=x.CeremonyDate,
                Status = x.Status
            }).ToList();
        }

        public List<CeremonyQueryModel> GetComing()
        {

            return _hContext.Ceremonies.Include(x => x.CeremonyGuests)
                                    .Where(x => x.Status == true &&
                                    DateTime.Now.Date <= x.CeremonyDate.Date &&
                                    DateTime.Compare(x.CeremonyDate.AddHours(5), DateTime.Now) > 0)
                                    .Select(x => new CeremonyQueryModel
                                    {
                                        Id = x.Id,
                                        Title = x.Title,
                                        CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                                        CeremonyTime = x.CeremonyDate.ToString("HH:mm"),
                                        CeremonyDate = x.CeremonyDate,
                                        Image = x.Image,
                                        ImageAlt = x.ImageAlt,
                                        ImageTitle = x.ImageTitle,
                                        IsLive = x.IsLive,
                                        BannerFile = x.BannerFile,
                                        Slug = x.Slug,
                                        Keywords = x.Keywords,
                                        MetaDescription = x.MetaDescription
                                    }).AsNoTracking().OrderBy(x => x.CeremonyDate).Take(4).Distinct().ToList();
        }
        public List<CeremonyQueryModel> GetComingBanner()
            {

                return _hContext.Ceremonies.Include(x => x.CeremonyGuests)
                                        .Where(x => x.Status == true &&
                                        DateTime.Now.Date <= x.CeremonyDate.Date &&
                                        DateTime.Compare(x.CeremonyDate.AddHours(5), DateTime.Now) > 0)
                                        .Select(x => new CeremonyQueryModel
                                        {
                                            Id = x.Id,
                                            Title = x.Title,
                                            CeremonyDateFa = x.CeremonyDate.ToFarsi(),
                                            CeremonyTime = x.CeremonyDate.ToString("HH:mm"),
                                            CeremonyDate = x.CeremonyDate,
                                            Image = x.Image,
                                            ImageAlt = x.ImageAlt,
                                            ImageTitle = x.ImageTitle,
                                            IsLive = x.IsLive,
                                            BannerFile = x.BannerFile,
                                            Slug = x.Slug,
                                            Keywords = x.Keywords,
                                            MetaDescription = x.MetaDescription
                                        }).AsNoTracking().OrderBy(x => x.CeremonyDate).Take(3).Distinct().ToList();

                //return _hContext.CeremonyGuests.Include(x => x.Ceremony)
                //                                    .Where(x => x.Ceremony.Status == true &&
                //                                    DateTime.Now.Date <= x.Ceremony.CeremonyDate.Date &&
                //                                    DateTime.Compare(x.Ceremony.CeremonyDate.AddHours(10), DateTime.Now) > 0)
                //                                    .Select(x => new CeremonyQueryModel
                //                                    {
                //                                        Id = x.Ceremony.Id,
                //                                        Title = x.Ceremony.Title,
                //                                        CeremonyDateFa = x.Ceremony.CeremonyDate.ToFarsi(),
                //                                        CeremonyTime = x.Ceremony.CeremonyDate.ToString("HH:mm"),
                //                                        CeremonyDate = x.Ceremony.CeremonyDate,
                //                                        Image = x.Ceremony.Image,
                //                                        ImageAlt = x.Ceremony.ImageAlt,
                //                                        ImageTitle = x.Ceremony.ImageTitle,
                //                                        IsLive = x.Ceremony.IsLive,
                //                                        BannerFile = x.Ceremony.BannerFile,
                //                                        Slug = x.Ceremony.Slug,
                //                                        Keywords = x.Ceremony.Keywords,
                //                                        MetaDescription = x.Ceremony.MetaDescription
                //                                    }).AsNoTracking().Take(3).Distinct().ToList();
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
            return _hContext.Ceremonies.
                                            Include(x => x.CeremonyGuests).
                                            ThenInclude(x => x.Guest).ThenInclude(x => x.Multimedias).
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
                                                Multimedias = MapMultimedias(x.Multimedias, 0,null,0)

                                            }).AsNoTracking().ToList();
        }

        public List<MultimediaQueryModel> Search(string phrase)
        {
            var query = _hContext.Ceremonies.Include(x => x.CeremonyGuests).ThenInclude(x => x.Guest).Include(x => x.Multimedias)
                .Where(x => x.Status == true).Select(x => new CeremonyQueryModel
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
                    Multimedias = MapMultimedias(x.Multimedias, 0, null, x.Id)
                }).ToList();


            foreach (var qu in query)
            {
                foreach (var item in qu.Multimedias)
                {
                    if (item.GuestId != null)
                    {
                        item.GuestName = _hContext.Guests.Where(x => x.Id == item.GuestId).FirstOrDefault().FullName;
                    }
                    else
                    {
                        item.GuestName = "";
                    }
                    item.Ceremony = qu.Title;
                    item.CeremonyDateFA = qu.CeremonyDateFa;
                    item.CeremonyDate = qu.CeremonyDate;
                }

            }


            //foreach (var ceremony in query)
            //{
            //    ceremony.Multimedias = _hContext.Multimedias.Include(x => x.Guest).Include(x => x.Ceremony).Where(x => x.Status == true).Select(x => new MultimediaQueryModel
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        FileAddress = x.FileAddress,
            //        FileAlt = x.FileAlt,
            //        GuestId = x.GuestId,
            //        Guest = x.Guest.FullName,
            //        FileTitle = x.FileTitle
            //    }).ToList();

            //}


            //if (!string.IsNullOrWhiteSpace(phrase))




            //var queryCer = query.AsEnumerable().Where(x => x.Title.Contains(phrase) || x.CeremonyDateFa.Contains(phrase) || x.ImageTitle.Contains(phrase) || x.Keywords.Contains(phrase) || x.MetaDescription.Contains(phrase) || x.CeremonyGuests.Any(a => a.Guest.Contains(phrase)));

            var queryMul = query.AsEnumerable().Where(x => x.Multimedias.Any(a => a.Title.Contains(phrase)) || x.Multimedias.Any(a => a.FileTitle != null && a.FileTitle.Contains(phrase)) || x.Multimedias.Any(a => a.GuestName.Contains(phrase))); //    (a => a.Guest?.ToLower().Contains(phrase) ?? false)

            var mediaList = new List<MultimediaQueryModel>();
            foreach (var qu in queryMul)
            {
                foreach (var item in qu.Multimedias)
                {
                    var mItem = new MultimediaQueryModel
                    {

                        Id = item.Id,
                        Title = item.Title,
                        FileAddress = item.FileAddress,
                        FileAlt = item.FileAlt,
                        FileTitle = item.FileTitle,
                        VisitCount = item.VisitCount,
                        GuestId = item.GuestId,
                        GuestName = item.GuestName,
                        Ceremony=item.Ceremony,
                        CeremonyId=item.CeremonyId,
                        CeremonyDate=item.CeremonyDate,
                        ContentType=item.ContentType
                        
                    };
                    mediaList.Add(mItem);

                }

            }


            var queryMulList = mediaList.AsEnumerable().Where(x => x.Title.Contains(phrase) || (x.FileTitle != null && x.FileTitle.Contains(phrase)) || x.GuestName.Contains(phrase));


            var res = queryMulList.ToList();
            return res;
        }

        private static List<MultimediaQueryModel> MapMultimedias(List<Multimedia> multimedias, int typeId, List<Ceremony> medias=null, long ceremonyId=0)
        {
            string contentType;

            var res = multimedias.Select(x => new MultimediaQueryModel {
                Id = x.Id,
                Title = x.Title,
                FileAddress = x.FileAddress,
                FileAlt = x.FileAlt,
                FileTitle = x.FileTitle,
                VisitCount = x.VisitCount,
                GuestId = x.GuestId,
                CeremonyId=x.CeremonyId
            }).ToList();


            //var res = new List<MultimediaQueryModel>();
            //foreach (var item in multimedias)
            //{

            //        var mItem = new MultimediaQueryModel
            //        {

            //            Id = item.Id,
            //            Title = item.Title,
            //            FileAddress = item.FileAddress,
            //            FileAlt = item.FileAlt,
            //            FileTitle = item.FileTitle,
            //            VisitCount = item.VisitCount,
            //            GuestId = item.GuestId,
            //            Guest = item.Guest.FullName
            //        };
            //        res.Add(mItem);

            //        new FileExtensionContentTypeProvider().TryGetContentType(item.FileAddress, out contentType);
            //        var ct = contentType;
            //        mItem.ContentType = ct;
            //}

            foreach (var item in res)
            {
                new FileExtensionContentTypeProvider().TryGetContentType(item.FileAddress, out contentType);
                var ct = contentType;
                item.ContentType = ct;
                //if (item.GuestId != null)
                //{
                //    item.Guest = medias.Where(x => x.GuestId == item.GuestId).Select(x => x.Guest.FullName).FirstOrDefault();
                //}
            }

            if (typeId == 1)
            {

                res = res.AsEnumerable().Where(x=>x.ContentType !=null && x.ContentType.StartsWith("image/")).ToList();
            }
            else if (typeId == 2)
            {

                res = res.AsEnumerable().Where(x => x.ContentType.StartsWith("audio/")).ToList();
            }
            else if (typeId == 3)
            {

                res = res.AsEnumerable().Where(x => x.ContentType.StartsWith("video/")).ToList();
            }

            return res.ToList();
        }

        //private static string MapMultimediasToGuest(List<Multimedia> multimedias, long id)
        //{
        //    string GuestName = "";
        //    foreach (var item in multimedias)
        //    {
        //        if (item.GuestId!=null)
        //        {
        //            GuestName = multimedias.Where(x => x.GuestId == item.GuestId).Select(x=>x.Guest.FullName).FirstOrDefault();
        //        }
        //        else
        //        {
        //            GuestName = "";
        //        }
        //    }

        //    return GuestName;

        //}

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
                                            ThenInclude(x => x.Guest).Include(x=>x.Multimedias).
                                            Where(x => x.Status == true && x.Slug !=null).Select(x => new CeremonyQueryModel
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
                                                Multimedias = MapMultimedias(x.Multimedias, typeId,null,0)
                                            }).AsNoTracking().FirstOrDefault(x => x.Slug == id);

            foreach (var multimedia in ceremonies.Multimedias)
            {
                if (multimedia.GuestId != null)
                {
                    multimedia.GuestName = _hContext.Guests.Where(x => x.Id == multimedia.GuestId).FirstOrDefault().FullName;

                }
                else
                {
                    multimedia.GuestName = "";
                }
            }

            return ceremonies;
        }



        public List<CeremonyQueryModel> GetAllCeremonyWithMultimedias()
        {
            var ceremonies = _hContext.Ceremonies.Include(x => x.CeremonyGuests).
                                            ThenInclude(x => x.Guest).
                                            Where(x => x.Slug !=null && x.CeremonyGuests.Count()>0 && x.Status == true && x.Multimedias.Count()>0).Select(x => new CeremonyQueryModel
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
                                                Multimedias = MapMultimedias(x.Multimedias, 0,null,0)
                                            }).AsNoTracking().OrderByDescending(x=>x.CeremonyDate).ToList();

            return ceremonies.ToList();
        }


        public List<CeremonyQueryModel> GetAllArchiveCeremonyWithMultimedias()
        {
            var ceremonies = _hContext.Ceremonies.Include(x => x.CeremonyGuests).
                                ThenInclude(x => x.Guest).
                                Where(x => x.Slug != null && x.CeremonyGuests.Count() > 0 && x.Status == true && x.CeremonyDate < DateTime.Now).Select(x => new CeremonyQueryModel
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
                                    Multimedias = MapMultimedias(x.Multimedias, 0,null,0)
                                }).AsNoTracking().OrderByDescending(x => x.CeremonyDate).ToList();

            return ceremonies.ToList();
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





