using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.CeremonyGuest;
using Haidarieh.Application.Contracts.Multimedia;
using Haidarieh.Configuration.Permissions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Admin.Pages.Multimedias
{
    public class EditAlbumModel : PageModel
    {
        public List<MultimediaViewModel> Command { get; set; }
        public object ViewBag { get; private set; }
        public SelectList Guests;

        //public MultimediaViewModel MVM { get; set; }
        private readonly ICeremonyGuestApplication _ceremonyGuestApplication;
        private readonly IMultimediaApplication _multimediaApplication;

        public EditAlbumModel(ICeremonyGuestApplication ceremonyGuestApplication, IMultimediaApplication multimediaApplication)
        {
            _ceremonyGuestApplication = ceremonyGuestApplication;
            _multimediaApplication = multimediaApplication;
        }
        public void OnGet(long Id)
        {
            ViewBag = Id;
            Command = _multimediaApplication.GetMultimediasWithCeremony(Id);
        }
        public IActionResult OnPost(EditMultimedia command, List<IFormFile> files)
        {
            var result = _multimediaApplication.EditAlbum(command, files);
            return RedirectToPage("./EditAlbum");
        }
        [NeedPermission(HPermissions.EditMultimedia)]
        public IActionResult OnGetRemove(long id,long ceremonyId)
        {
            _multimediaApplication.Delete(id);
            //var showList=OnGetShow(command);
            //return Partial("Show", showList);
            //return new JsonResult(result);
            return RedirectToPage("./EditAlbum", new { id = ceremonyId });
        }
        public IActionResult OnGetAdd(long id)
        {
            var command = _multimediaApplication.GetDetail(id);
            command.Guests = _ceremonyGuestApplication.GetCeremonyGuestsVM(id); //new SelectList(_ceremonyGuestApplication.GetCeremonyGuestsVM(id), "Id", "Title");
            return Partial("./Add", command);


        }
        public JsonResult OnPostAdd(EditMultimedia createcommand, List<IFormFile> FileAddress)
        {
            var result = _multimediaApplication.EditAlbum(createcommand, FileAddress);
            return new JsonResult(result);
        }
    }
}
