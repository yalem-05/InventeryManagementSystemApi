using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Features.Query.ItemQuery.Query;
using Test.Application.PersistenceInterface;

namespace Test.Application.Features.Query.ItemQuery.Handler
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, List<GetItemDto>>
    {
        private readonly IItem item;
        private readonly IMapper mapper;
        public GetItemQueryHandler(IItem _item, IMapper _mapper)
        {
            item= _item;
            mapper= _mapper;
        }
        public async Task<List<GetItemDto>> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var data = await item.GetAll();
            return mapper.Map<List<GetItemDto>>(data);
            //throw new NotImplementedException();
        }
    }
}
