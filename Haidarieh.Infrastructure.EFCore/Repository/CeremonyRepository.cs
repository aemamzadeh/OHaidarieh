using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Infrastructure.EFCore;
using Haidarieh.Application.Contracts.Ceremony;
using Haidarieh.Application.Contracts.CeremonyGuest;
using Haidarieh.Application.Contracts.Guest;
using Haidarieh.Domain.CeremonyAgg;
using Haidarieh.Domain.CeremonyGuestAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Haidarieh.Infrastructure.EFCore.Repository
{
    public class CeremonyRepository : RepositoryBase<long, Ceremony>, ICeremonyRepository
    {
        private readonly HContext _hContext;
        private readonly AccountContext _accountContext;

        public CeremonyRepository(HContext hContext, AccountContext accountContext) : base(hContext)
        {
            _hContext = hContext;
            _accountContext = accountContext;
        }

        public List<CeremonyViewModel> GetCeremonies()
        {
            return _hContext.Ceremonies.Where(x=>x.Status && x.CeremonyGuests.Count()>0 && x.Multimedias.Count()<=0).Select(x => new CeremonyViewModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDate=x.CeremonyDate,
                CeremonyDateFA = x.CeremonyDate.ToFarsi(),
                Image = x.Image,
                IsLive = x.IsLive
            }).ToList();
        }


        public List<CeremonyViewModel> GetCeremonieswithGuests()
        {
            return _hContext.Ceremonies.Include(x => x.CeremonyGuests).ThenInclude(x => x.Guest).Where(x => x.Status)
                .Select(x => new CeremonyViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    CeremonyDate = x.CeremonyDate,
                    CeremonyDateFA = x.CeremonyDate.ToFarsi(),
                    Image = x.Image,
                    IsLive = x.IsLive,
                    CeremonyGuests = MapGuests(x.CeremonyGuests)
                }).ToList();
        }

        private static List<CeremonyGuestViewModel> MapGuests(List<CeremonyGuest> ceremonyGuests)
        {
            var guests = new List<CeremonyGuestViewModel>();
            foreach (var item in ceremonyGuests)
            {
                var gst = new CeremonyGuestViewModel
                {
                    Id = item.Id,
                    CeremonyId = item.CeremonyId,
                    GuestId = item.GuestId,
                    GuestType = GuestTypes.GetGuestType(item.Guest.GuestType),
                    Guest = item.Guest.FullName,
                    GuestPic = item.Guest.Image,
                    Satisfication = (item.Satisfication).ToPersianNumber()
                };
                guests.Add(gst);
            }
            return guests;
        }




        public List<CeremonyViewModel> GetCeremonyWithOperationsLog2()
        {
            return _hContext.Ceremonies.Select(x => new CeremonyViewModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDate = x.CeremonyDate,
                CeremonyDateFA = x.CeremonyDate.ToFarsi(),
                CeremonyOperations = GetCeremonyOperationsLog(x.CeremonyOperations)
            }).AsNoTracking().ToList();
        }

        public List<CeremonyOperationViewModel> GetCeremonyWithOperationsLog()
        {
            var result = new List<CeremonyOperationViewModel>();
            var ceremonies = _hContext.Ceremonies.ToList();
            foreach (var cer in ceremonies)
            {
                foreach (var op in cer.CeremonyOperations)
                {
                    var ops = new CeremonyOperationViewModel
                    {
                        Id = op.Id,
                        CeremonyId = op.CeremonyId,
                        Ceremony = op.Ceremony.Title,
                        Description = op.Description,
                        Operation = op.Operation,
                        OperationDate = op.OperationDate.ToFarsi(),
                        OperatorId = op.OperatorId
                    };
                    result.Add(ops);
                }
                var users = _accountContext.Accounts.Select(x => new { x.Id, x.Fname,x.Lname}).ToList();
                foreach (var item in result)
                {
                    var user = users.FirstOrDefault(x => x.Id == item.OperatorId);
                    if (user !=null)
                    {
                        item.OperatorName = user.Fname+" "+user.Lname;
                    }
                }
            }

            return result.OrderByDescending(x=>x.Id).ToList();
        }

        protected static List<CeremonyOperationViewModel> GetCeremonyOperationsLog(List<CeremonyOperation> ceremonyOperations)
        {
            var result = new List<CeremonyOperationViewModel>();
            foreach (var ceremonyOperation in ceremonyOperations)
            {
                var Item = new CeremonyOperationViewModel
                {
                    Id = ceremonyOperation.Id,
                    CeremonyId = ceremonyOperation.CeremonyId,
                    Ceremony = ceremonyOperation.Ceremony.Title,
                    Description = ceremonyOperation.Description,
                    Operation = ceremonyOperation.Operation,
                    OperationDate = ceremonyOperation.OperationDate.ToFarsi(),
                    OperatorId = ceremonyOperation.OperatorId
                };
                result.Add(Item);
            }
            return result;
        }

        public EditCeremony GetDetail(long id)
        {
            //CultureInfo provider = CultureInfo.InvariantCulture;

            return _hContext.Ceremonies.Select(x => new EditCeremony()
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDate=x.CeremonyDate.ToFarsiFull(), //.ToString(CultureInfo.InvariantCulture),
                IsLive = x.IsLive,
                ImageAlt = x.ImageAlt,
                ImageTitle = x.ImageTitle,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Slug = x.Slug,
                
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CeremonyViewModel> Search(CeremonySearchModel searchModel)
        {
            var query = _hContext.Ceremonies.Where(x=>x.CeremonyDate>=DateTime.Today).Include(x => x.CeremonyGuests).ThenInclude(x => x.Guest)
                .Select(x => new CeremonyViewModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDateFA = x.CeremonyDate.ToFarsi(),
                CeremonyDate=x.CeremonyDate,
                IsLive = x.IsLive,
                Image = x.Image,

            }).OrderByDescending(x => x.CeremonyDate).ToList();

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
                query = query.Where(x => x.Title.Contains(searchModel.Title)).ToList();

            return query;
        }

        public List<CeremonyViewModel> GetUpcommingCeremonies()
        {
            return _hContext.Ceremonies.Where(x => x.Status && x.CeremonyDate>=System.DateTime.Today).Select(x => new CeremonyViewModel
            {
                Id = x.Id,
                Title = x.Title,
                CeremonyDate = x.CeremonyDate,
                CeremonyDateFA = x.CeremonyDate.ToFarsi(),
                Image = x.Image,
                IsLive = x.IsLive
            }).ToList();
        }
    }
}
