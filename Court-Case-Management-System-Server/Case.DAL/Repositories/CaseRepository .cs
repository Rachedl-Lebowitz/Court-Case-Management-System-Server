using Shred.Models.DTO;

namespace CaseService.DAL.Repositories
{
    public class CaseRepository : ICaseRepository
    {
        public CaseDto CreateCase(CaseDto caseDto)
        {
            // Logic for creating the case in the DB 
            return caseDto; // Return the created file with the generated ID.
        }
    }
}