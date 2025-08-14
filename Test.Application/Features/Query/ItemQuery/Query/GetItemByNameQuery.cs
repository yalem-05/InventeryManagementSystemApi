using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Features.Query.ItemQuery.Query
{
    public class GetItemByNameQuery: IRequest<GetItemDto>
    {
        public required string itemNames { get; set; }
    }
}
