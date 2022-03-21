using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Data.Models
{
    public class Price
    {
        [Column("id")]
        public Guid Id { get; set; }
        public decimal ProductPrice { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
