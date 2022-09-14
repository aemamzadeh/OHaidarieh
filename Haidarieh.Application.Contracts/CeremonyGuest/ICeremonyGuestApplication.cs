using _0_Framework.Application;
using Haidarieh.Application.Contracts.Ceremony;
using Haidarieh.Application.Contracts.Guest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haidarieh.Application.Contracts.CeremonyGuest
{
    public interface ICeremonyGuestApplication
    {
        OperationResult Create(CreateCeremonyGuest command);
        OperationResult Edit(EditCeremonyGuest command,int[] chk);
        //Dictionary<long, List<CeremonyGuestViewModel>> Search(CeremonyGuestSearchModel searchModel);
        List<CeremonyViewModel> Search(CeremonyGuestSearchModel searchModel);
        EditCeremonyGuest GetDetail(long Id);
        //Dictionary<long, List<CeremonyGuestViewModel>> GetDetail(long Id);
        List<CeremonyGuestViewModel> GetCeremonyGuests(long id=0);
        OperationResult Delete(long Id);
        List<CeremonyGuestViewModel> GetGuests(long id = 0);
        List<CeremonyGuestViewModel> GetRestGuests(List<CeremonyGuestViewModel> restList);
        List<GuestViewModel> GetCeremonyGuestsVM(long id = 0);




    }
}
