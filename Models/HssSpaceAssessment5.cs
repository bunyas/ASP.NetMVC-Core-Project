using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment5
    {
        public HssSpaceAssessment5()
        {
            HssSpaceAssessmentKeyInformantInterview = new HashSet<HssSpaceAssessmentKeyInformantInterview>();
            HssSpaceAssessmentMedicineStore1Navigation = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessmentMedicineStore2Navigation = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessmentSuppliesStore1Navigation = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessmentSuppliesStore2Navigation = new HashSet<HssSpaceAssessment>();
        }

        public string SpaceAssessment5Code { get; set; }
        public string SpaceAssessment5Desc { get; set; }

        public virtual ICollection<HssSpaceAssessmentKeyInformantInterview> HssSpaceAssessmentKeyInformantInterview { get; set; }
        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessmentMedicineStore1Navigation { get; set; }
        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessmentMedicineStore2Navigation { get; set; }
        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessmentSuppliesStore1Navigation { get; set; }
        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessmentSuppliesStore2Navigation { get; set; }
    }
}
