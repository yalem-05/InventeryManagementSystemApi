using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Features.Command.UserCommand.Query;
using Test.Application.PersistenceInterface;
using Test.Domain.Entity;

namespace Test.Application.Features.Command.UserCommand.Handler
{
    public class CreateUserQueryHandler : IRequestHandler<CreateUserQuery, UserDto>
    {
        private readonly IUser user;
        private readonly IMapper mapper;

        public CreateUserQueryHandler(IUser _user, IMapper _mapper)
        {
            user = _user;
            mapper = _mapper;
        }



        public async Task<UserDto> Handle(CreateUserQuery request, CancellationToken cancellationToken)
        {
            var userEntity = mapper.Map<User>(request.userDtoQuery);
            var entity= await user.addData(userEntity);
            return mapper.Map<UserDto>(entity);
            //throw new NotImplementedException();
        }
    }
}
