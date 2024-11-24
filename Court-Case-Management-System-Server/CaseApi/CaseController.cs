using Microsoft.AspNetCore.Mvc;
using CaseService.BL.Services;
using Shred.Models.DTO;
using System.Threading.Tasks;
using Case.BL.Services.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class CaseController : ControllerBase
{
    private readonly ICaseService _caseService;

    public CaseController(ICaseService caseService)
    {
        _caseService = caseService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCase([FromBody] CaseDto caseDto)
    {
        var newCase = await _caseService.CreateCaseAsync(caseDto);
        return Ok(newCase);
    }


    [HttpGet]
    public async Task<List<CaseDto>> GetCases()
    {
        var cases = await _caseService.GetCases();
        return cases;
    }
}