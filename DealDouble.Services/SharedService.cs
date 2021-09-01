using DealDouble.Data;
using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
    public class SharedService
    {
        public int SaveImage(Image image)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Images.Add(image);
            context.SaveChanges();
            return image.ID;
        }
    }
}
