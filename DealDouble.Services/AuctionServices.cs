using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealDouble.Data;
using DealDouble.Entities;

namespace DealDouble.Services
{
    public class AuctionServices
    {
        public Auction GetAuctionByID(int id)
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.Find(id);
           
        }

        public List<Auction> GetAllAuctions()
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.ToList();

        }
        public void SaveAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Auctions.Add(auction);
            context.SaveChanges();
        }

        public void UpdateAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
