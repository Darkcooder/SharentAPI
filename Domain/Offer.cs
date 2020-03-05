using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Domain
{
    public class Offer
    {
        public Guid Id { get; set; }
        public Realty Realty { get; set; }
        public Owner Owner { get; set; }
        public DateTime DateTimeBegin { get; set; }
        public int DateTimeCellSize { get; set; }
        public int DateTimeCellCount { get; set; }
        public int CellTax { get; set; }
        public bool Canceled { get; set; }
        public bool ReserveApproveEnabled { get; set; }
    }
}
