using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateRecipientEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool? Lmis { get; set; }
        public bool? Reporting { get; set; }
    }
}
