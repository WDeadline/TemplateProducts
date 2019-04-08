using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class ExportBill
    {
        public long Id { get; set; }

        public long OwnerId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
