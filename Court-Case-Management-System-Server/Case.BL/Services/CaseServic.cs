using Case.BL.Services.Interfaces;
using CaseService.DAL.Repositories;
using Messaging.Interfaces;
using Shared.Messaging;
using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaseService.BL.Services
{
    public class CaseServic : ICaseService
    {
        private readonly ICaseRepository _caseRepository;
        private readonly IMessagePublisher _messagePublisher;

        public CaseServic(ICaseRepository caseRepository, IMessagePublisher messagePublisher)
        {
            _caseRepository = caseRepository;
            _messagePublisher = messagePublisher;
        }

        public async Task<CaseDto> CreateCaseAsync(CaseDto caseDto)
        {
            var newCase = _caseRepository.CreateCase(caseDto);

            var notificationMessage = new NotificationMessage
            {
                CaseId = newCase.CaseId,
                Message = "New case created"
            };

            await _messagePublisher.PublishAsync(notificationMessage);

            return newCase;
        }
        public async Task<List<CaseDto>> GetCases()
        {
            

            List<CaseDto> cases = new List<CaseDto>
            {
            new CaseDto
            {
                CaseId = 1,
                CaseNumber = "984690",
                CaseType = "lawsuit action",
                CaseTypeId = 1,
                FileOpeningDate = new DateTime(2024, 11, 23),
                EligibilityPeriod = "2024-11-23  2024-12-29",
                CloseDiscussion = new DateTime(2024-12-29),
                RespondentProxyId = 201,
                RespondentProxy = "Lawyer Haim",
                ChairmanCommitteeId = 301,
                ChairmanCommittee = "Mr. Moshe",
                PublicRepresentativeId = 401,
                PublicRepresentative = "Ms. Rachel",
                AppealSubmitterId = 501,
                AppealSubmitter = "Mr. Dan",
                PractitionerId = 101,
                Practitioner = "Lawyer Yehuda",
                StatusId = 1,
                Status = "open"
            },
            new CaseDto
            {
                CaseId = 2,
                CaseNumber = "909816",
                CaseType = "lawsuit prosecution",
                CaseTypeId = 2,
                FileOpeningDate = new DateTime(2024, 5, 1),
                EligibilityPeriod = "2024-05-01  2024-09-29",
                CloseDiscussion = new DateTime(2024, 09, 29),
                RespondentProxyId = 202,
                RespondentProxy = "Lawyer Shlomo",
                ChairmanCommitteeId = 302,
                ChairmanCommittee = "Mr. Levi",
                PublicRepresentativeId = 402,
                PublicRepresentative = "Ms. Lea",
                AppealSubmitterId = 502,
                AppealSubmitter = "Mr. David",
                PractitionerId = 102,
                Practitioner = "Lawyer Sara",
                StatusId = 2,
                Status = "close"
            },
            new CaseDto
            {
                CaseId = 3,
                CaseNumber = "11456990",
                CaseType = "Administrative lawsuit",
                CaseTypeId = 3,
                FileOpeningDate = new DateTime(2023, 2, 10),
                EligibilityPeriod = "2023-02-10  2024-10-31",
                CloseDiscussion = new DateTime(2024, 10, 31),
                RespondentProxyId = 203,
                RespondentProxy = "Lawyer Shoshana",
                ChairmanCommitteeId = 303,
                ChairmanCommittee = "Mr. Salmon",
                PublicRepresentativeId = 403,
                PublicRepresentative = "Ms. Miriam,
                AppealSubmitterId = 503,
                AppealSubmitter = "Mr. Yisrael,
                PractitionerId = 103,
                Practitioner = "Lawyer Shulamit",
                StatusId = 1,
                Status = "open"
            },
            new CaseDto
            {
                CaseId = 4,
                CaseNumber = "39387",
                CaseType = "Financial lawsuit",
                CaseTypeId = 4,
                FileOpeningDate = new DateTime(2024, 6, 6),
                EligibilityPeriod = "2024-06-06  2024-09-30",
                CloseDiscussion = new DateTime(2024, 9, 30),
                RespondentProxyId = 204,
                RespondentProxy = "Lawyer Miriam",
                ChairmanCommitteeId = 304,
                ChairmanCommittee = "Mr. Yitchak",
                PublicRepresentativeId = 404,
                PublicRepresentative = "Ms. yael",
                AppealSubmitterId = 504,
                AppealSubmitter = "Mr. Refael",
                PractitionerId = 104,
                Practitioner = "Lawyer Tamar",
                StatusId = 2,
                Status = "close"
            },
            new CaseDto
            {
                CaseId = 5,
                CaseNumber = "76312",
                CaseType = "Damages lawsuit",
                CaseTypeId = 5,
                FileOpeningDate = new DateTime(2024, 4, 13),
                EligibilityPeriod = "2024-04-13  2024-10-10",
                CloseDiscussion = new DateTime(2024, 10, 10),
                RespondentProxyId = 205,
                RespondentProxy = "Lawyer Levi,
                ChairmanCommitteeId = 305,
                ChairmanCommittee = "Mr. Abraam",
                PublicRepresentativeId = 405,
                PublicRepresentative = "Ms. Ayala",
                AppealSubmitterId = 505,
                AppealSubmitter = "Ms. Chana,
                PractitionerId = 105,
                Practitioner = "Lawyer Yosef",
                StatusId = 1,
                Status = "open"
            } };
            return cases;
                }
    }
    
    
}
    
