using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAReleaseInstruction
    {
        public FoAReleaseInstruction()
        {
            FoCertificateReleaseFrmQuarantine = new HashSet<FoCertificateReleaseFrmQuarantine>();
            FoQiCloseOutCertificate = new HashSet<FoQiCloseOutCertificate>();
        }

        public int RiCode { get; set; }
        public string ReleaseInstructionDesc { get; set; }

        public virtual ICollection<FoCertificateReleaseFrmQuarantine> FoCertificateReleaseFrmQuarantine { get; set; }
        public virtual ICollection<FoQiCloseOutCertificate> FoQiCloseOutCertificate { get; set; }
    }
}
