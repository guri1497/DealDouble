using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionServices auctionServices = new AuctionServices();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Listing()
        {
            var model = auctionServices.GetAllAuctions();
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            auctionServices.SaveAuction(auction);
            return RedirectToAction("Listing");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var model = auctionServices.GetAuctionByID(ID);
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionServices auctionServices = new AuctionServices();
            auctionServices.SaveAuction(auction);
            return RedirectToAction("Listing");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var model = auctionServices.GetAuctionByID(ID);
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            auctionServices.DeleteAuction(auction);
            return RedirectToAction("Listing");
        }
    }
}