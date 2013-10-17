using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbracoLatest.Controllers
{
    using System.Web.Http;

    using Umbraco.Web.Mvc;

    using UmbracoLatest.Models;

    public class CarSurfaceController : SurfaceController
    {
        public PartialViewResult Index()
        {
            return PartialView("_ContactForm");
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult HandleCar(ContactFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                return PartialView("_Success");
            }

            return PartialView("_ContactForm", model);
        }
    }
}
