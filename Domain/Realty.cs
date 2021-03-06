﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Domain
{
    public class Realty
    {
        public Guid Id { get; set; }
        public Owner Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PageUrl { get; set; }
    }
}
