using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_HaidariehQuery.Contracts.Ceremonies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages.MultimediaDetail
{
    public class GalleryArchiveModel : PageModel
    {
        private readonly ICeremonyQuery _ceremonyQuery;
        public List<CeremonyQueryModel> ceremonies { get; set; }

        public GalleryArchiveModel(ICeremonyQuery ceremonyQuery)
        {
            _ceremonyQuery = ceremonyQuery;
        }

        public void OnGet(int pageId = 1)
        {
            var ceremoniesCount = _ceremonyQuery.GetAllCeremonyWithMultimedias().Count();
            var skip = (pageId - 1) * 10;
            int pageCount = ceremoniesCount / 10;
            ViewData["pageId"] = pageId;
            ViewData["pageCount"] = pageCount;
            ceremonies = _ceremonyQuery.GetAllCeremonyWithMultimedias().Skip(skip).Take(10).ToList();
        }
    }
}
