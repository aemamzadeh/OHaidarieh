using _0_Framework.Application.Email;
using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.Ceremony;
using Haidarieh.Application.Contracts.CeremonyGuest;
using Haidarieh.Application.Contracts.Guest;
using Haidarieh.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.CeremonyGuests
{
    public class CreateModel : PageModel
    {
        private readonly ICeremonyGuestApplication _ceremonyGuestApplication;
        private readonly ICeremonyApplication _ceremonyApplication;
        private readonly IGuestApplication _guestApplication;
        //public CreateCeremonyGuest CeremonyGuest;
        private readonly IEmailService _emailService;
        public GuestSearchModel SearchModel;
        public List<GuestViewModel> Guests;
        public EditCeremonyGuest ceremonyGuest;


        public CreateModel(IGuestApplication guestApplication, ICeremonyApplication ceremonyApplication, ICeremonyGuestApplication ceremonyGuestApplication, IEmailService emailService)
        {
            _guestApplication = guestApplication;
            _ceremonyApplication = ceremonyApplication;
            _ceremonyGuestApplication = ceremonyGuestApplication;
            _emailService = emailService;
        }

        public void OnGet(GuestSearchModel searchModel, long ceremonyId)
        {

            ceremonyGuest = _ceremonyGuestApplication.GetDetail(ceremonyId);
            ceremonyGuest.Guests = _ceremonyGuestApplication.GetRestGuests(ceremonyGuest.Guests);
            //Guests = _guestApplication.Search(searchModel);

            //CeremonyGuest = new CreateCeremonyGuest
            //{
            //    Ceremonies = _ceremonyApplication.GetUpcommingCeremonies(),
            //    Guests = _guestApplication.GetGuests()
            //};
        }

        //[NeedPermission(HPermissions.EditCeremonyGuest)]
        public IActionResult OnPostCreate(EditCeremonyGuest command,int[] chk)
        {

            _ceremonyGuestApplication.Edit(command, chk);
            //return new ation(result);
            return RedirectToPage("./Index");


            //var result = _ceremonyGuestApplication.Create(command);
            //var ceremony = _ceremonyApplication.GetDetail(command.CeremonyId);
            //var guests = _ceremonyGuestApplication.GetCeremonyGuests(command.CeremonyId);
            //var guestInfo = _guestApplication.GetGuestsInfo(guests);
            //foreach (var item in guestInfo)
            //{
            //    _emailService.SendEmail(ceremony.Title, " جناب آقای دعوتنامه شرکت در در مراسم", item.Email);
            //}

            //return new JsonResult(result);
        }
        //public IActionResult OnGetEdit(long ceremonyId)
        //{
        //    //var selectedceremony = _ceremonyApplication.GetDetail(ceremonyId);
        //    //selectedceremony.CeremonyGuests = _ceremonyGuestApplication.GetCeremonyGuests(ceremonyId);
        //    ceremonyGuest = _ceremonyGuestApplication.GetDetail(ceremonyId);
        //    ceremonyGuest.Guests = _ceremonyGuestApplication.GetGuests();
        //    //ceremonyGuest.Guests = _ceremonyGuestApplication.GetCeremonyGuests(ceremonyId);
        //    //ViewData["guests"] = _guestApplication.GetGuests();
        //    //ceremonyGuest.Guests = _guestApplication.GetGuests();
        //    //ceremonyGuest.Ceremonies = _ceremonyApplication.GetCeremonies();
        //    return Partial("Edit", ceremonyGuest);
        //}

        //public JsonResult OnGetEdit(EditCeremonyGuest command, int[] chk)
        //{

        //    var result = _ceremonyGuestApplication.Edit(command, chk);
        //    return new JsonResult(result);
        //}
    }
}
