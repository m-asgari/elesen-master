using System.Collections.Generic;
namespace TradingLicense.Model
{
    public class HAReqDocModel
    {
        public int HAReqDocID { get; set; }

        public int RequiredDocID { get; set; }

        public string RequiredDocDesc { get; set; }

        public string IsChecked { get; set; }

        public string AttachmentFileName { get; set; }

        public int AttachmentId { get; set; }

        public List<int> RequiredDocs { get; set; }

        public int HawkerApplicationID { get; set; }
    }
}
