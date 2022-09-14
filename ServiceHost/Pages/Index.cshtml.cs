using System.Collections.Generic;
using _01_HaidariehQuery.Contracts.Ceremonies;
using _01_HaidariehQuery.Contracts.Multimedias;
using Haidarieh.Application.Contracts.Member;
using Haidarieh.Application.Contracts.Multimedia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class IndexModel : PageModel
    {
        public CreateMember Member { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public List<MultimediaQueryModel> ceremony { get; set; }
        public CeremonyQueryModel searchModel { get; set; }

        private readonly IMemberApplication _memberApplication;
        private readonly IMultimediaApplication _multimediaApplication;
        private readonly ICeremonyQuery _ceremonyQuery;
        



        public IndexModel(IMemberApplication memberApplication, IMultimediaApplication multimediaApplication, ICeremonyQuery ceremonyQuery)
        {
            _memberApplication = memberApplication;
            _multimediaApplication = multimediaApplication;
            _ceremonyQuery = ceremonyQuery;
        }

        public void OnGet()
        {

        }
        public void OnPostCreate(CreateMember Member)
        {

            if (!ModelState.IsValid)
            {
                ErrorMessage = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
            }
            else
            {
                _memberApplication.Create(Member);
                SuccessMessage = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
                ModelState.Clear();
            }
        }
        public JsonResult OnGetAddVisitCount(long id)
        {
            var newnumber = _multimediaApplication.AddVisitCount(id);
            return new JsonResult(newnumber);
        }
        public RedirectToPageResult OnGetSearch(string search)
        {
            return RedirectToPage("/Search?search=", search);
        }
    }
}
