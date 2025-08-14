using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Features.Command.ItemCommand.Query;
using Test.Application.Features.Query.ItemQuery.Query;

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

        [HttpGet]
        public async Task<IActionResult> GetItemData()
        {
            var allData = new GetItemQuery();
            var data = await mediator.Send(allData);
            return Ok(data);
        }

        [HttpGet("itemName")]
        public async Task<IActionResult> GetEementByName(string itemName) {

            var commandGetItemName = new GetItemByNameQuery { itemNames = itemName };
            var allData = await mediator.Send(commandGetItemName);
            if (allData == null) {  return Ok("this item   " +itemName +  "   not found"); }

            return Ok(allData);
        }
    }
}
