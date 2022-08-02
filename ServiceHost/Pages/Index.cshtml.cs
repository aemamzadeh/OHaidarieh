using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haidarieh.Application.Contracts.Member;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ServiceHost.Pages
{
    public class IndexModel : PageModel
    {
        public CreateMember Member { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        private readonly IMemberApplication _memberApplication;

        public IndexModel(IMemberApplication memberApplication)
        {
            _memberApplication = memberApplication;
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
    }
}
