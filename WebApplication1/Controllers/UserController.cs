using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Entity;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController: ControllerBase
{
    private List<User> _users = new List<User>
    {
        new()
        {
            Name = "User1"
        },
        new()
        {
            Name = "User2"
        },
        new()
        {
            Name = "User3"
        },
        new()
        {
            Name = "User4"
        }
    };

    [HttpGet]
    [ProducesResponseType(typeof(List<User>),200, "application/json")]
    public IActionResult GetAllUsers()
    {
        return Ok(_users);
    }

    // [ActionName("GetSingle")]
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(User),200, "application/json")]
    [ProducesResponseType(404)]
    public IActionResult GetSingleUser(Guid id)
    {
        return Ok(_users.FirstOrDefault(x => x.Id == id));
    }

    [HttpPost]
    [ProducesResponseType(typeof(User),201, "application/json")]
    [ProducesResponseType(400)]
    public IActionResult AddUser([FromBody] UserInputDto dto)
    {
        var newUser = new User
        {
            Name = dto.Name
        };
        _users.Add(newUser);
        return CreatedAtAction(nameof(GetSingleUser), new { id = newUser.Id }, newUser);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        var user = _users.FirstOrDefault(x => x.Id == id);
        _users.Remove(user);
        return Ok();
    }
}