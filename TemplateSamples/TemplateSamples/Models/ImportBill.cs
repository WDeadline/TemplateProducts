using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class ImportBill
    {
        public long Id { get; set; }

        public long ProducerId { get; set; }

        public DateTime DateOfPayment { get; set; }


    }
}
