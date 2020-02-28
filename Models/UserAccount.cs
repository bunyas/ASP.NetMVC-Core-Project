using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            ADriverAddedByNavigation = new HashSet<ADriver>();
            ADriverEditedByNavigation = new HashSet<ADriver>();
            AVehicleAddedByNavigation = new HashSet<AVehicle>();
            AVehicleEditedByNavigation = new HashSet<AVehicle>();
            ApprovedFacilityOrdersApprovedByNavigation = new HashSet<ApprovedFacilityOrders>();
            ApprovedFacilityOrdersIssuedByNavigation = new HashSet<ApprovedFacilityOrders>();
            MileageFormAddedByNavigation = new HashSet<MileageForm>();
            MileageFormEditedByNavigation = new HashSet<MileageForm>();
            PhysicalCountHeaderAddedByNavigation = new HashSet<PhysicalCountHeader>();
            PhysicalCountHeaderEditedByNavigation = new HashSet<PhysicalCountHeader>();
            TreatmentEstimatedRecuitsAddedByNavigation = new HashSet<TreatmentEstimatedRecuits>();
            TreatmentEstimatedRecuitsEditedByNavigation = new HashSet<TreatmentEstimatedRecuits>();
            VehicleDriverAllocationAddedByNavigation = new HashSet<VehicleDriverAllocation>();
            VehicleDriverAllocationEditedByNavigation = new HashSet<VehicleDriverAllocation>();
            VehiclePackingListAllocationAddedByNavigation = new HashSet<VehiclePackingListAllocation>();
            VehiclePackingListAllocationEditedByNavigation = new HashSet<VehiclePackingListAllocation>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int? FacilitorCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<ADriver> ADriverAddedByNavigation { get; set; }
        public virtual ICollection<ADriver> ADriverEditedByNavigation { get; set; }
        public virtual ICollection<AVehicle> AVehicleAddedByNavigation { get; set; }
        public virtual ICollection<AVehicle> AVehicleEditedByNavigation { get; set; }
        public virtual ICollection<ApprovedFacilityOrders> ApprovedFacilityOrdersApprovedByNavigation { get; set; }
        public virtual ICollection<ApprovedFacilityOrders> ApprovedFacilityOrdersIssuedByNavigation { get; set; }
        public virtual ICollection<MileageForm> MileageFormAddedByNavigation { get; set; }
        public virtual ICollection<MileageForm> MileageFormEditedByNavigation { get; set; }
        public virtual ICollection<PhysicalCountHeader> PhysicalCountHeaderAddedByNavigation { get; set; }
        public virtual ICollection<PhysicalCountHeader> PhysicalCountHeaderEditedByNavigation { get; set; }
        public virtual ICollection<TreatmentEstimatedRecuits> TreatmentEstimatedRecuitsAddedByNavigation { get; set; }
        public virtual ICollection<TreatmentEstimatedRecuits> TreatmentEstimatedRecuitsEditedByNavigation { get; set; }
        public virtual ICollection<VehicleDriverAllocation> VehicleDriverAllocationAddedByNavigation { get; set; }
        public virtual ICollection<VehicleDriverAllocation> VehicleDriverAllocationEditedByNavigation { get; set; }
        public virtual ICollection<VehiclePackingListAllocation> VehiclePackingListAllocationAddedByNavigation { get; set; }
        public virtual ICollection<VehiclePackingListAllocation> VehiclePackingListAllocationEditedByNavigation { get; set; }
    }
}
