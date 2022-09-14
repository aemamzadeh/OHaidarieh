using Microsoft.AspNetCore.Mvc;
using _01_HaidariehQuery.Contracts.Ceremonies;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ServiceHost.ViewComponents
{
    public class BannersViewComponent: ViewComponent
    {
        private readonly ICeremonyQuery _ceremonyQuery;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public List<string> ImageList { get; set; }


        public BannersViewComponent(ICeremonyQuery ceremonyQuery, IWebHostEnvironment webHostEnvironment)
        {
            _ceremonyQuery = ceremonyQuery;
            _webHostEnvironment = webHostEnvironment;
        }

        public IViewComponentResult Invoke()
        {
            var provider = new PhysicalFileProvider(_webHostEnvironment.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("Theme", "Images"));
            var objFiles = contents.OrderBy(m => m.LastModified);
            ImageList = new List<string>();
            foreach (var item in objFiles.ToList())
            {
                ImageList.Add(item.Name);
            }
            ViewData["ImageList"] = ImageList;
            var banner = _ceremonyQuery.GetComingBanner();
            return View(banner);
        }

    }
}
