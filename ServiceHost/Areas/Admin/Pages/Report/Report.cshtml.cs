using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_HaidariehQuery.Contracts.Ceremonies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Report
{
    public class ReportModel : PageModel
    {
        private readonly ICeremonyQuery _ceremonyQuery;
        public List<CeremonyQueryModel> ceremonies { get; set; }

        public ReportModel(ICeremonyQuery ceremonyQuery)
        {
            _ceremonyQuery = ceremonyQuery;
        }

        public void OnGet()
        {
            ceremonies = _ceremonyQuery.GetAllCeremonyWithMultimedias();
        }
    }
}
