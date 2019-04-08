using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class Material
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public Enum Unit { get; set; }
    }
}
