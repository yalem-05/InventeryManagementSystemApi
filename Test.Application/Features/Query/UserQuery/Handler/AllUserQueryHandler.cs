using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Features.Query.UserQuery.Queries;
using Test.Application.PersistenceInterface;

namespace Test.Application.Features.Query.UserQuery.Handler
{
    public class AllUserQueryHandler : IRequestHandler<AllUserQuery, List<GetUserDto>>
    {
        private readonly IUser user;
        private readonly IMapper mapper;

        public AllUserQueryHandler(IUser _user, IMapper _mapper)
        {
            user = _user;
            mapper = _mapper;
        }

        public async Task<List<GetUserDto>> Handle(AllUserQuery request, CancellationToken cancellationToken)
        {
            var entitiy = await user.GetAll();
            return mapper.Map<List<GetUserDto>>(entitiy);


            //throw new NotImplementedException();
        }
    }
}
