using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class ProductPrice
    {
        public long ProductId { get; set; }

        public DateTime DateApplied { get; set; }

        public double Price { get; set; }
    }
}
