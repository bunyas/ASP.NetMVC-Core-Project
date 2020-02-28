using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpScheduledDeliveries
    {
        public DateTime DepartureDate { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? ExpectedDateAtSite { get; set; }
        public DateTime? ActualDateAtSite { get; set; }
    }
}
