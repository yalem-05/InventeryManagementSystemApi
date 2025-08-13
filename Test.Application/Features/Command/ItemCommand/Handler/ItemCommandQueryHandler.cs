using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Features.Command.ItemCommand.Query;
using Test.Application.PersistenceInterface;
using Test.Domain.Entity;

namespace Test.Application.Features.Command.ItemCommand.Handler
{
    public class ItemCommandQueryHandler : IRequestHandler<ItemCommandQuery, ItemDto>
    {
        private readonly IItem item;
        private readonly IMapper mapper;
        public ItemCommandQueryHandler(IItem _item, IMapper _mapper)
        {
            item= _item;
            mapper= _mapper;
        }
        public async Task<ItemDto> Handle(ItemCommandQuery request, CancellationToken cancellationToken)
        {
            var itemEntity = mapper.Map<Item>(request.Itemdto);
            var data=await item.addData(itemEntity);

            return mapper.Map<ItemDto>(data);
            
            //throw new NotImplementedException();
        }
    }
}
