using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Features.Command.UserCommand.Query;
using Test.Application.Features.Query.UserQuery.Queries;
using Test.Application.PersistenceInterface;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMediator mediator;
        public UserController(IMediator _mediatr)
        {
            mediator = _mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {
            var createCommand = new CreateUserQuery { userDtoQuery = userDto };
            var data = await mediator.Send(createCommand);
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetaLData()
        {
            var data = new AllUserQuery();
            var dataa=await mediator.Send(data);

            return Ok(dataa);

        }
    }
}
