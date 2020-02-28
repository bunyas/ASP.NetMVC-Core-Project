using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisPatientNoList
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SummaryYear { get; set; }
        public int? SummaryMonth { get; set; }
        public int? RegimenClassification { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public short RegimenCode { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? TotalPatients { get; set; }
    }
}
