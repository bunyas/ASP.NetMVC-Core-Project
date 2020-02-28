using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderLabAmc
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfAmc { get; set; }
        public int ItemCode { get; set; }
        public double? Amc { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProductLabCategory ItemCodeNavigation { get; set; }
    }
}
