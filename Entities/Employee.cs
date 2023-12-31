﻿using System;
using System.Collections.Generic;

namespace creamU_API.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Messages = new HashSet<Message>();
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Telephone { get; set; }
        public string? Password { get; set; }
        public int? EmailId { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Title { get; set; }
        public DateTime? JoinDate { get; set; }
        public string? Notes { get; set; }

        public virtual Account? Email { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
