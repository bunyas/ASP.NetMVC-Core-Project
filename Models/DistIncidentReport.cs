using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistIncidentReport
    {
        public DistIncidentReport()
        {
            DistIncidentReportOtherVehicle = new HashSet<DistIncidentReportOtherVehicle>();
            DistIncidentReportWitness = new HashSet<DistIncidentReportWitness>();
        }

        public string OperatorPermit { get; set; }
        public string VehicleRegistartion { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string TripAuthorityNo { get; set; }
        public DateTime? TimeOfIncident { get; set; }
        public string LocationOfIncident { get; set; }
        public int? NoOfVehiclesInvolved { get; set; }
        public int? NoOfWitnesses { get; set; }
        public int? NoOfPeopleInjured { get; set; }
        public string DamageOrgVehicle { get; set; }
        public string PoliceOfficer { get; set; }
        public string PoliceCaseNo { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateRecieved { get; set; }
        public string OtherObjects { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public byte[] DiagramCrash { get; set; }
        public string InjuryOperator { get; set; }
        public string InjuryOtherParty { get; set; }

        public virtual DistOperatorPermit OperatorPermitNavigation { get; set; }
        public virtual DistVehicleInventory VehicleRegistartionNavigation { get; set; }
        public virtual ICollection<DistIncidentReportOtherVehicle> DistIncidentReportOtherVehicle { get; set; }
        public virtual ICollection<DistIncidentReportWitness> DistIncidentReportWitness { get; set; }
    }
}
