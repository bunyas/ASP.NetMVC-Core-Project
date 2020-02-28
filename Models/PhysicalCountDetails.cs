using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PhysicalCountDetails
    {
        public int FacilityCode { get; set; }
        public DateTime DateRecorded { get; set; }
        public int DrugCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int? UnitPacksDispensary { get; set; }
        public int? UnitPacksStore { get; set; }
        public string LotNumber { get; set; }

        public virtual ADrugFormulation DrugCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual PhysicalCountHeader PhysicalCountHeader { get; set; }
    }
}
