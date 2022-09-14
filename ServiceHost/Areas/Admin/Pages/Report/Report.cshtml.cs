using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haidarieh.Application.Contracts.Ceremony;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Report
{
    public class ReportModel : PageModel
    {
        private readonly ICeremonyApplication _ceremonyApplication;
        public List<CeremonyViewModel> ceremonies { get; set; }

        public ReportModel(ICeremonyApplication ceremonyApplication)
        {
            _ceremonyApplication = ceremonyApplication;
        }

        public void OnGet()
        {
            ceremonies = _ceremonyApplication.GetCeremonieswithGuests();
        }
    }
}
