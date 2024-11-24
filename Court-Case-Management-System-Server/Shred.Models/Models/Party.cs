using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models
{
    public class Party
    {
        public string PartyId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } 
        public ICollection<CaseEntity> Cases { get; set; }
    }
}
