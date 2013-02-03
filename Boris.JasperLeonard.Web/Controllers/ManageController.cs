using System.Web.Mvc;
using Boris.JasperLeonard.Business;
using Boris.JasperLeonard.Web.Models;

namespace Boris.JasperLeonard.Web.Controllers
{
    public class ManageController : Controller
    {
        private readonly SlideshowManager slideshowManager;

        public ManageController(SlideshowManager slideshowManager)
        {
            this.slideshowManager = slideshowManager;
        }

        public ActionResult SlideShow()
        {
            var model = new SlideshowModel();
            model.SlideshowNames = slideshowManager.SlideshowNames;
            return View(model);
        }

    }
}
