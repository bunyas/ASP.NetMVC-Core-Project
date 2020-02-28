using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int SpaceAssessment2Code { get; set; }
        public int SpaceAssessment3Code { get; set; }
        public string MedicineStore1 { get; set; }
        public string MedicineStore2 { get; set; }
        public string SuppliesStore1 { get; set; }
        public string SuppliesStore2 { get; set; }
        public string Dispensary { get; set; }
        public string Comments { get; set; }

        public virtual HssSpaceAssessmentMaster HssSpaceAssessmentMaster { get; set; }
        public virtual HssSpaceAssessment5 MedicineStore1Navigation { get; set; }
        public virtual HssSpaceAssessment5 MedicineStore2Navigation { get; set; }
        public virtual HssSpaceAssessment2 SpaceAssessment2CodeNavigation { get; set; }
        public virtual HssSpaceAssessment3 SpaceAssessment3CodeNavigation { get; set; }
        public virtual HssSpaceAssessment5 SuppliesStore1Navigation { get; set; }
        public virtual HssSpaceAssessment5 SuppliesStore2Navigation { get; set; }
    }
}
