using Shred.Models.DTO;

namespace CaseService.DAL.Repositories
{
    public interface ICaseRepository
    {
        CaseDto CreateCase(CaseDto caseDto);
    }
}