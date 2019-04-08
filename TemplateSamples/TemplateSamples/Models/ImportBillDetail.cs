using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class ImportBillDetail
    {
        public long ImportBillId { get; set; }

        public long MaterialId { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

    }
}
