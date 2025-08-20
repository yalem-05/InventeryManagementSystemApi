using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entity
{
    public class gitCheck
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        public required string ItemName { get; set; }
        public string  ItemCode { get; set; }
        public string ItemCatagory { get; set; }
        public string ItemType { get; set; }

    }
}
