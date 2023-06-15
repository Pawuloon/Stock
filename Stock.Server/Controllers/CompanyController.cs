using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stock.Server.Services;
using Stock.Shared.Models;

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
        catch (NullReferenceException e)
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
        catch (Exception e)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(GetCompany), new {id = company.Id}, company);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCompany(int id, [FromBody]Company company)
    {
        if (id != company.Id)
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
        catch (Exception e)
        {
            return BadRequest();
        }
        return NoContent();
    }
}