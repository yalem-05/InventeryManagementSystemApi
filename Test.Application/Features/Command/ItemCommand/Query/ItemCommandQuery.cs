using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Features.Command.ItemCommand.Query
{
    public class ItemCommandQuery :IRequest<ItemDto>
    {
        public ItemDto Itemdto { get; set; }
    }
}
