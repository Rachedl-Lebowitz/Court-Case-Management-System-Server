using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class DecisionDto
    {
        public string DecisionId { get; set; }
        public string CaseId { get; set; }
        public string Description { get; set; }
        public DateTime DecisionDate { get; set; }
    }
}
