using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FileCollectionSupDoc
    {
        public string Id { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
        public int? ERegComplaintCode { get; set; }
        public string BatchNo { get; set; }
        public int? ProductCode { get; set; }
        public int? QualityIssueCode { get; set; }
        public string ERegComplaintNo { get; set; }

        public virtual FoComplaintQualityIssue QualityIssueCodeNavigation { get; set; }
    }
}
