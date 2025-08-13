using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Features.Command.ItemCommand.Query;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMediator mediator;
        public ItemController(IMediator _mediatr)
        {
            mediator = _mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] ItemDto itemDto)
        {
            var createItem= new ItemCommandQuery { Itemdto = itemDto };
            var data= await mediator.Send(createItem);
            return Ok(createItem);
        }
    }
}
