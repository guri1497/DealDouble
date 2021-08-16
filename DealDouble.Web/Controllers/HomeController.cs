using DealDouble.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class HomeController : Controller
    {
        DealDouble.Services.AuctionServices auction = new Services.AuctionServices();
        public ActionResult Index()
        {
            AuctionViewModel vModel = new AuctionViewModel();
            vModel.Title = "Homepage";
            vModel.Description = "I am the description";
            vModel.AllAuctions = auction.GetAllAuctions();
            vModel.PromotedAuctions = auction.GetPromotedAuctions();
            return View(vModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}