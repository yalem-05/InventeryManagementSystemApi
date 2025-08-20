using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class ItemDto
    {
        //public Guid Id { get; set; }
        public required string ItemName { get; set; }
        public Guid ItemCode { get; set; }
        public string ItemCatagory { get; set; }
        public string ItemType { get; set; }
        public string ItemBrand { get; set; }
        public string ItemModel { get; set; }
        public string ItemSerial { get; set; }
        public int status { get; set; }
        public DateTime RegDate { get; set; }
        public Guid CraetedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid UserId { get; set; }
    }
}
