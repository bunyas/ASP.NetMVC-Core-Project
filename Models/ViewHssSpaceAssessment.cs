using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssSpaceAssessment
    {
        public int SpaceAssessment1Code { get; set; }
        public string SpaceAssessment1Desc { get; set; }
        public int SpaceAssessment2Code { get; set; }
        public string SpaceAssessment2Desc { get; set; }
        public int? SpaceAssessment3Code { get; set; }
        public string SpaceAssessment3Desc { get; set; }
        public string MedicineStore1 { get; set; }
        public string MedicineStore2 { get; set; }
        public string SuppliesStore1 { get; set; }
        public string SuppliesStore2 { get; set; }
        public string Dispensary { get; set; }
        public string Comments { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? DateOfVisit { get; set; }
    }
}
