//using System.Collections.Generic;

namespace AllJoin.Entities
{
    public record Employee : EntityBase
    {
        public int? DepartmentId { get; set; }

        public int? BankId { get; set; }
    }
}
