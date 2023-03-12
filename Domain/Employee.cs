using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public int ResolvedTasks { get; set; }

        public double Efficiency { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
