using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Domain
{
    public class Owner
    {
        public Guid Id { get; set; }
        public User User { get; set; }
    }
}
