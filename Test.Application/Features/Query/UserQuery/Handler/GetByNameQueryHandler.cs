using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Features.Query.UserQuery.Queries;
using Test.Application.PersistenceInterface;
using Test.Domain.Entity;

namespace Test.Application.Features.Query.UserQuery.Handler
{
    public class GetByNameQueryHandler : IRequestHandler<GetByNameQuery, GetUserDto>
    {
        private readonly IUser user;
        private readonly IMapper mapper;

        public GetByNameQueryHandler(IUser _user, IMapper _mapper)
        {
            user = _user;
            mapper = _mapper;
        }

        public async Task<GetUserDto> Handle(GetByNameQuery request, CancellationToken cancellationToken)
        {
          
           return await user.GetUserByName(request.firstName);

            //throw new NotImplementedException();
        }
    }
}
