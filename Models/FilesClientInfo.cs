using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FilesClientInfo
    {
        public string Id { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
        public int? DocCategory { get; set; }
        public bool? Archive { get; set; }
    }
}
