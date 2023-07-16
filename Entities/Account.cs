using System;
using System.Collections.Generic;

namespace creamU_API.Entities
{
    public partial class Account
    {
        public Account()
        {
            Employees = new HashSet<Employee>();
            Members = new HashSet<Member>();
        }

        public int EmailId { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
