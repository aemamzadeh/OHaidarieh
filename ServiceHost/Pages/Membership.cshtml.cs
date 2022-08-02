using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haidarieh.Application.Contracts.Member;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MembershipModel : PageModel
    {
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }

        private readonly IMemberApplication _imemberApplication;

        public MembershipModel(IMemberApplication imemberApplication)
        {
            _imemberApplication = imemberApplication;
        }

        public void OnGet()
        {

        }
        public void OnPost(CreateMember command)
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
            }
            else
            {
                _imemberApplication.Create(command);
                SuccessMessage = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
                ModelState.Clear();
            }
        }
    }
}
