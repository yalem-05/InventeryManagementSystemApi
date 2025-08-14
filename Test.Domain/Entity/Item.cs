using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entity
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        public required string ItemName { get; set; }
        public string  ItemCode { get; set; }
        public string ItemCatagory { get; set; }
        public string ItemType { get; set; }
        public string ItemBrand { get; set; }
        public string ItemModel { get; set; }
        public string ItemSerial { get; set; }
        public int status { get; set; }
        public DateTime RegDate { get; set; }
     
        public Guid CraetedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

    }
}
