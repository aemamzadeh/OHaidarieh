using _01_HaidariehQuery.Contracts.Multimedias;
using Haidarieh.Application.Contracts.Multimedia;
using Haidarieh.Domain.MultimediaAgg;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ServiceHost.ViewComponents
{
    public class MostVisitedCeremoniesViewComponent : ViewComponent
    {
        private readonly IMultimediaQuery _multimediaQuery;
        //private readonly IMultimediaApplication _multimediaApplication;

        public MostVisitedCeremoniesViewComponent(IMultimediaQuery multimediaQuery)
        {
            _multimediaQuery = multimediaQuery;
            //_multimediaApplication = multimediaApplication;
        }

        public IViewComponentResult Invoke()
        {
            var mostVisitedevents = _multimediaQuery.GetMultimediasWithCeremony(3).Take(6);
            return View(mostVisitedevents);
        }

        //public void AddVisitCount(long id)
        //{
        //    _multimediaApplication.AddVisitCount(id);
        //}
    }
}