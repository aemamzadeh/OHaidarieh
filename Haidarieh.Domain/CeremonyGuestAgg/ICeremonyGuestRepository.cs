using _0_Framework.Domain;
using Haidarieh.Application.Contracts.Ceremony;
using Haidarieh.Application.Contracts.CeremonyGuest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haidarieh.Domain.CeremonyGuestAgg
{
    public interface ICeremonyGuestRepository : IRepository<long, CeremonyGuest>
    {
        //Dictionary<long, List<CeremonyGuestViewModel>> GetDetail(long Id);
        EditCeremonyGuest GetDetail(long Id);
        //Dictionary<long, List<CeremonyGuestViewModel>> Search(CeremonyGuestSearchModel searchModel);
        List<CeremonyViewModel> Search(CeremonyGuestSearchModel searchModel);
        List<CeremonyGuestViewModel> GetCeremonyGuests(long id=0);
        CeremonyGuestViewModel GetDeleteGuest(long command, long guestId);
        List<CeremonyGuestViewModel> GetGuests(long id = 0);
        List<CeremonyGuestViewModel> GetRestGuests(List<CeremonyGuestViewModel> restList);
    }
}
