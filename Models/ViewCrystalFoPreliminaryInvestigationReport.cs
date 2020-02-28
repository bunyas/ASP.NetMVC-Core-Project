using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalFoPreliminaryInvestigationReport
    {
        public int ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public string BatchNo { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryDesc { get; set; }
        public string ProductSuppliedByMaul { get; set; }
        public string ProductSuppliedOtherFacilities { get; set; }
        public string SameComplaintRegistered { get; set; }
        public string ProductSampleSent { get; set; }
        public string OrganolepicProperty { get; set; }
        public string StockAtMaul { get; set; }
        public string MaulPipline { get; set; }
        public string OrdersAboutDispatched { get; set; }
        public string WarehouseQuarantine { get; set; }
        public string FacilityQuarantine { get; set; }
        public string DiferShipment { get; set; }
        public string CancelShipment { get; set; }
        public string SwitchProduct { get; set; }
        public string ObtainReplacement { get; set; }
        public string OtherActions { get; set; }
    }
}
