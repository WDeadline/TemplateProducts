using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class ExportBillDetail
    {
        public long ExportBillId { get; set; }

        public long MaterialId { get; set; }

        public int Quantity { get; set; }
    }
}
