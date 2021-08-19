using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Entities
{
    public class AuctionImage : BaseEntity
    {
        public int ImageID { get; set; }
        public Image Image { get; set; }
        public int AuctionID { get; set; }
    }
}
