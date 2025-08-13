using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Features.Command.UserCommand.Query
{
    public class CreateUserQuery :IRequest<UserDto>
    {
       public  UserDto userDtoQuery { get; set; }
    }
}
