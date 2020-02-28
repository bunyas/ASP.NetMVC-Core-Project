﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssDbQueryDnGrn
    {
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? LevelOfCare { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCode { get; set; }
        public string CategoryDesc { get; set; }
        public string BatchNo { get; set; }
        public string DnNumber { get; set; }
        public DateTime? DateRecorded { get; set; }
        public string Packsize { get; set; }
        public double? QuantityMaulDn { get; set; }
        public string GrnNumber { get; set; }
        public double? QuantityGrn { get; set; }
        public double? QuantityStockCard { get; set; }
        public bool? QuantitiesAgree { get; set; }
        public string Comment { get; set; }
    }
}
