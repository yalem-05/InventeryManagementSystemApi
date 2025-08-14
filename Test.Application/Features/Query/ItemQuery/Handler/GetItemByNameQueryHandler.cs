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
using Test.Domain.Entity;

namespace Test.Application.Features.Query.ItemQuery.Handler
{
    public class GetItemByNameQueryHandler : IRequestHandler<GetItemByNameQuery, GetItemDto>
    {
        private readonly IItem item;
        private readonly IMapper mapper;

        public GetItemByNameQueryHandler(IItem _item, IMapper _mapper)
        {
            item = _item;
            mapper = _mapper;
        }
        public async Task<GetItemDto> Handle(GetItemByNameQuery request, CancellationToken cancellationToken)
        {
            return await item.GetItemByName(request.itemNames);

            //throw new NotImplementedException();
        }
    }
}
