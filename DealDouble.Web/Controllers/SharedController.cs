using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class SharedController : Controller
    {
        SharedService service = new SharedService();
       [HttpPost]
        public ActionResult UploadImages()
        {
            var images = Request.Files;
            for(var i = 0; i < images.Count; i++)
            {
                var image = images[i];
                var fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                var path = Server.MapPath("~/Content/Images/") + fileName;
                image.SaveAs(path);
                var dbImage = new Image();
                dbImage.URL = fileName;
                var imageID = service.SaveImage(dbImage);
            }
            return View();
        }
    }
}