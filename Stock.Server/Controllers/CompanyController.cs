using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stock.Server.Services;


namespace Stock.Server.Controllers;
[Authorize]
[Route("api/stock")]
public class CompanyController : ControllerBase
{
    private readonly CompanyService _service;

    public CompanyController(CompanyService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetCompanies()
    {
        return Ok(await _service.GetCompanies());
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCompany(int id)
    {
        try
        {
            var company = await _service.GetCompany(id);
            return Ok(company);
        }
        catch (NullReferenceException)
        {
            return NotFound();
        }
       
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCompany([FromBody]Company company)
    {
        try
        {
            await _service.AddCompany(company);
        }
        catch (Exception)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(GetCompany), new {name = company.Name}, company);
    }
    
    [HttpPut("{name}")]
    public async Task<IActionResult> UpdateCompany(string name, [FromBody]Company company)
    {
        if (name != company.Name)
        {
            return BadRequest();
        }

        await _service.UpdateCompany(company);
        return NoContent();
    }
    
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCompany(int id)
    {
        try
        {
            await _service.DeleteCompany(id);
        }
        catch (Exception)
        {
            return BadRequest();
        }
        return NoContent();
    }
}