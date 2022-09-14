using _01_HaidariehQuery.Contracts.Ceremonies;
using _01_HaidariehQuery.Contracts.Multimedias;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ICeremonyQuery _ceremonyQuery;
        public List<MultimediaQueryModel> ceremony { get; set; }
        public CeremonyQueryModel searchModel { get; set; }



        public SearchModel(ICeremonyQuery ceremonyQuery)
        {
            _ceremonyQuery = ceremonyQuery;
        }
        public void OnGet(string search)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                ceremony = _ceremonyQuery.Search(search);
            }
            else
            {
                ceremony = null;
            }
        }
        public void OnPostSearch(CeremonyQueryModel searchmodel, int pageId = 1)
        {
            if (!string.IsNullOrWhiteSpace(searchmodel.Title))
            {
                ceremony = _ceremonyQuery.Search(searchmodel.Title);
            }
            else
            {
                ceremony= null;
            }
        }

    }

}

