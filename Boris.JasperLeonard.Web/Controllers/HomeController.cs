using System.Web.Mvc;
using Boris.JasperLeonard.Business;
using Boris.JasperLeonard.Web.Models;

namespace Boris.JasperLeonard.Web.Controllers
{
    public class HomeController : Controller
    {
        private SlideshowManager slideshowManager;

        public HomeController(SlideshowManager slideshowManager)
        {
            this.slideshowManager = slideshowManager;
            SlideshowManager.ContentPath = Url.Content(@"~\slideshows");
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slideshow(string showname)
        {
            var model = new SlideshowModel();
            model.ImagePaths = slideshowManager.GetImagePaths(showname);

            return View(model);
        }

        //public ActionResult Video()
        //{
        //    http://vimeo.com/53361182
        //}

    }
}
