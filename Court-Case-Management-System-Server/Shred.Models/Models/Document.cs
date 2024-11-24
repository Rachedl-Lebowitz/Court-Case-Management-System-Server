using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models
{
    public class Document
    {
        public string DocumentId { get; set; }
        public string CaseId { get; set; }
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
