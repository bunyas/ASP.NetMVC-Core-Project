﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SapSmcSiteOrderHeader
    {
        public SapSmcSiteOrderHeader()
        {
            SapSmcSiteOrderDocumetLines = new HashSet<SapSmcSiteOrderDocumetLines>();
        }

        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public bool? CurrentReccord { get; set; }
        public bool? RecordReadBySap { get; set; }
        public string DocNum { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? DocDueDate { get; set; }
        public string CardCode { get; set; }
        public int? DocEntry { get; set; }

        public virtual OrderSmcHeader OrderSmcHeader { get; set; }
        public virtual ICollection<SapSmcSiteOrderDocumetLines> SapSmcSiteOrderDocumetLines { get; set; }
    }
}
