using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Boris.JasperLeonard.Business;
using Boris.JasperLeonard.Web.Models;

namespace Boris.JasperLeonard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SlideshowManager slideshowManager;

        public HomeController(SlideshowManager slideshowManager)
        {
            this.slideshowManager = slideshowManager;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slideshow(string showname)
        {
            var model = new SlideshowModel();
            model.ShowName = showname;
            model.ImagePaths = GetImagePaths(showname).ToList();

            return View(model);
        }

        private IEnumerable<string> GetImagePaths(string showname)
        {
            const string format = "{0}/{1}/{2}";
            var slideshowsPath = Url.Content(@"/Content/slideshows");
            return slideshowManager.GetImageNames(showname).Select(n => string.Format(format, slideshowsPath, showname, n));
        }

        //public ActionResult Video()
        //{
        //    http://vimeo.com/53361182
        //}

    }
}
