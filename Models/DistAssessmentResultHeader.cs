using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistAssessmentResultHeader
    {
        public DistAssessmentResultHeader()
        {
            DistAssessmentResult = new HashSet<DistAssessmentResult>();
        }

        public DateTime DateOfAssessment { get; set; }
        public string DriverPermitNo { get; set; }
        public int? Location { get; set; }
        public int? VehicleType { get; set; }
        public string Assessor { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistLocation LocationNavigation { get; set; }
        public virtual DistVehicleType VehicleTypeNavigation { get; set; }
        public virtual ICollection<DistAssessmentResult> DistAssessmentResult { get; set; }
    }
}
