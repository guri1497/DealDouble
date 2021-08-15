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
            var model = auctionServices.GetAllAuctions();
            return View(model);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            auctionServices.SaveAuction(auction);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var model = auctionServices.GetAuctionByID(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionServices auctionServices = new AuctionServices();
            auctionServices.SaveAuction(auction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var model = auctionServices.GetAuctionByID(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            auctionServices.DeleteAuction(auction);
            return RedirectToAction("Index");
        }
    }
}