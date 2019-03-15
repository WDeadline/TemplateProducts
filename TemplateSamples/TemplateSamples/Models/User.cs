using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Models
{
    public class User
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }

        public byte[] Salt { get; set; }

        public byte[] Password { get; set; }

        public bool Active { get; set; } = true;

        public IEnumerable<Permission> Roles { get; set; }
    }
}
