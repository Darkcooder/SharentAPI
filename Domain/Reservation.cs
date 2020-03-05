using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Domain
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Offer Offer { get; set; }
        public Client Client { get; set; }
        public int BeginDateTimeCell { get; set; }
        public int DateTimeCellCount { get; set; }
        public int Price { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCanceled { get; set; }

    }
}
