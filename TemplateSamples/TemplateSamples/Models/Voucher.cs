using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class Voucher
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Version { get; set; }
    }
}
