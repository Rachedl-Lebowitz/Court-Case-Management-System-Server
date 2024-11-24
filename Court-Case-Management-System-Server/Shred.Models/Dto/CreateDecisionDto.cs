using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class CreateDecisionDto
    {
        public string Description { get; set; }
        public DateTime DecisionDate { get; set; }
    }
}
