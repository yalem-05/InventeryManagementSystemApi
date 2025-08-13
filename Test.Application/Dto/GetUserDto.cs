using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class GetUserDto
    {
        public Guid Id { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }
        public required string EmpId { get; set; }
        public required string Email { get; set; }
        public required string PhoneNo { get; set; }
        public required int Blokno { get; set; }
        public required int Oficeno { get; set; }
        public DateTime RegDate { get; set; }
        public int Stataus { get; set; }
        public Guid CraetedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
