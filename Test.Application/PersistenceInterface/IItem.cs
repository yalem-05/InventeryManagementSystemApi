using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Domain.Entity;
using Test.Domain.IGenericInterfave;

namespace Test.Application.PersistenceInterface
{
    public interface IItem: IGeneric<Item>
    {
      Task<GetItemDto> GetItemByName(string itemName);
    }
}
