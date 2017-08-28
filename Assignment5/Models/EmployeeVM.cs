using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool MaritalStatus { get; set; }
        public int StateId { get; set; }
        public int CtyId { get; set; }
        public IEnumerable<MyCty> City { get; set; }
        public IEnumerable<State> State { get; set; }
        public Emp Employee { get; set; }
    }
}