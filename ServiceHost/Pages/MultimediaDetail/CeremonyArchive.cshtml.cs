using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_HaidariehQuery.Contracts.Ceremonies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages.MultimediaDetail
{
    public class CeremonyArchiveModel : PageModel
    {
        private readonly ICeremonyQuery _ceremonyQuery;
        public List<CeremonyQueryModel> ceremonies { get; set; }

        public CeremonyArchiveModel(ICeremonyQuery ceremonyQuery)
        {
            _ceremonyQuery = ceremonyQuery;
        }

        public void OnGet(int pageId=1)
        {
            var ceremoniesCount = _ceremonyQuery.GetAllArchiveCeremonyWithMultimedias().Count();
            var skip = (pageId - 1) * 10;
            int pageCount = ceremoniesCount / 10;
            ViewData["pageId"] = pageId;
            ViewData["pageCount"] = pageCount;
            ceremonies = _ceremonyQuery.GetAllArchiveCeremonyWithMultimedias().Skip(skip).Take(10).ToList();
        }
    }
}