using Microsoft.AspNetCore.Mvc;
using Stock.Server.Services;
using Stock.Shared.Models;

namespace Stock.Server.Controllers;

public class UserController : ControllerBase
{
    private readonly UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await _service.GetUsers());
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        try
        {
            var user = await _service.GetUser(id);
            return Ok(user);
        }
        catch (NullReferenceException e)
        {
            return NotFound();
        }
       
    }
    
    
    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody]User user)
    {
        try
        {
            await _service.AddUser(user);
        }
        catch (Exception e)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(GetUser), new {id = user.Id}, user);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody]User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

        await _service.UpdateUser(user);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        try
        {
            await _service.DeleteUser(id);
        }
        catch (NullReferenceException e)
        {
            return NotFound();
        }
        return NoContent();
    }
    
}