using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{

    // /test/hello-world
    [HttpGet("hello-world")]
    public string HelloWorld()
    {
        return "Hello World!";
    }

    [HttpGet("random-person")]
    public List<Person> RandomPerson()
    {
        return [new Person
        {
            Id = Guid.NewGuid(),
            Name = "Ironman",
        }, new Person
        {
            Id = Guid.NewGuid(),
            Name = "Ironman",
        }];
    }

    [HttpGet("action-result")]
    public IActionResult TestActionResult()
    {
        Random random = new Random();
        double num = random.NextDouble();

        if (num < 0.3)
        {
            return BadRequest("Something went wrong.");
        }
        else if (num < 0.6)
        {
            return Ok("Success!");
        }
        else
        {
            return NotFound("Whut?");
        }
    }

    [HttpPost("create-user")]
    public IActionResult ExampleCreateUser(
        [FromBody] CreateUserRequest user
    )
    {
        return Ok(new UserResponse
        {
            Id = Guid.NewGuid(),
            Username = user.Username
        });
    }

    [HttpDelete("delete-user/{userId}")]
    public void ExampleDeleteUser(Guid userId)
    {
        Console.WriteLine(userId);
    }

    [HttpGet("search-users")]
    public void ExampleSearchUsers(
        [FromQuery] string username,
        [FromQuery] int age,
        [FromQuery] string email
    )
    {
        Console.WriteLine(username);
        Console.WriteLine(age);
        Console.WriteLine(email);
    }
}

public class CreateUserRequest
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}

public class UserResponse
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
}


public class Person
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}