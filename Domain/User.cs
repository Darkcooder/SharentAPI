﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string VkClientId { get; set; }
    }
}
