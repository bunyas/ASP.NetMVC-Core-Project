using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class TreatmentEstimatedRecuits
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
    }
}
