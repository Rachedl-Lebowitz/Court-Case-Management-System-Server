using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shred.Models
{
    public class CaseEntity
    {
        public string CaseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OpenedDate { get; set; }
        public string Status { get; set; }
        public ICollection<Discussion> Discussions { get; set; }
        public ICollection<Decision> Decisions { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
