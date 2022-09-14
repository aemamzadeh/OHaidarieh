using _01_HaidariehQuery.Contracts.Multimedias;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class PastAudiosViewComponent:ViewComponent
    {
        private readonly IMultimediaQuery _multimediaQuery;

        public PastAudiosViewComponent(IMultimediaQuery multimediaQuery)
        {
            _multimediaQuery = multimediaQuery;
        }
        public IViewComponentResult Invoke()
        {
            var pastAudios = _multimediaQuery.GetMultimediasWithCeremony(2).Take(4);
            return View(pastAudios);
        }
    }
}
