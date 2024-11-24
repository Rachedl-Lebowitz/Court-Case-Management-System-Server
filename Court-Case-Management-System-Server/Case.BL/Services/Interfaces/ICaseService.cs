using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.BL.Services.Interfaces
{
    public interface ICaseService
    {
        Task<CaseDto> CreateCaseAsync(CaseDto caseDto);
        Task<List<CaseDto>> GetCases();
    }
}
