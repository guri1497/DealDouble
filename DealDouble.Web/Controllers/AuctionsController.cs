﻿using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            return View();
        }
    }
}