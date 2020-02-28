using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class NotificationServer
    {
        public int HostId { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpHost { get; set; }
        public bool? EnableSsl { get; set; }
        public bool? DefaultHost { get; set; }
        public int? NoReminders { get; set; }
        public short? ReminderInterval { get; set; }
        public string Remindees { get; set; }
    }
}
