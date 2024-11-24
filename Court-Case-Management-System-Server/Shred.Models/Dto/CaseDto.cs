using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class CaseDto
    {
        public int CaseId { get; set; }
        public string CaseNumber { get; set; }
        public int PractitionerId { get; set; }
        public string Practitioner { get; set; }
        public int CaseTypeId { get; set; }
        public string CaseType { get; set; }
        public DateTime FileOpeningDate { get; set; }
        public string EligibilityPeriod { get; set; }
        public DateTime CloseDiscussion { get; set; }
        public int RespondentProxyId { get; set; }
        public string RespondentProxy { get; set; }
        public int ChairmanCommitteeId { get; set; }
        public string ChairmanCommittee { get; set; }
        public int PublicRepresentativeId { get; set; }
        public string PublicRepresentative { get; set; }
        public int AppealSubmitterId { get; set; }
        public string AppealSubmitter { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }

    }
}
