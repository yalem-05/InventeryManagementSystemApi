using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Features.Query.UserQuery.Queries
{
    public class GetByNameQuery: IRequest<GetUserDto>
    {
        public required string firstName { get; set; }
    }
}
