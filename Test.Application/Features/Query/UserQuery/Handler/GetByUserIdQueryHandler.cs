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

namespace Test.Application.Features.Query.UserQuery.Handler
{
    public class GetByUserIdQueryHandler : IRequestHandler<GetByUserIdQuery, List<ItemDto>>
    {
        private readonly IItem item;
        private readonly IMapper mapper;
         
        public GetByUserIdQueryHandler(IItem _item, IMapper _mapper)
        {
            item= _item;
            mapper= _mapper;
        }
         
        public async Task<List<ItemDto>> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
        {
            var data=await item.GetAllDataWithId(request.Id);
           return mapper.Map<List<ItemDto>> (data);
            //throw new NotImplementedException();
        }
    }
}
