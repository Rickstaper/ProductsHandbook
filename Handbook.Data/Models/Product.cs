using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal Quantity { get; set; }
        public string Model { get; set; }
        public string Sort { get; set; }
        public string color { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public DateTime DateChanges { get; set; }

        public Guid PriceId { get; set; }
        public Price Price { get; set; }
    }
}
