using DealDouble.Entities;
using DealDouble.Services;
using DealDouble.Web.ViewModels;
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
            AuctionListingViewModel model = new AuctionListingViewModel();
            model.Title = "Auction Home";
            model.Description = "i am descirption";
            return View(model);
        }


        [HttpGet]
        public ActionResult Listing()
        {
            AuctionListingViewModel model = new AuctionListingViewModel();
            model.Auctions = auctionServices.GetAllAuctions();
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
            auctionServices.UpdateAuction(auction);
            return RedirectToAction("Listing");
        }

        
        [HttpPost]
        public ActionResult Delete(int ID)
        {
              var auction = auctionServices.GetAuctionByID(ID);
              auctionServices.DeleteAuction(auction);
              return RedirectToAction("Listing");

        }

        [HttpGet]
        public ActionResult Details(int ID)
        {
            var model = auctionServices.GetAuctionByID(ID);
            return View(model);
        }
    }
}