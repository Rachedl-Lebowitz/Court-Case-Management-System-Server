using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class DocumentDto
    {
        public string DocumentId { get; set; }
        public string CaseId { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
