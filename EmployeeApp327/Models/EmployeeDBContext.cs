using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeApp327.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext()
            : base("name=EmployeeDBContext") // Matches the connection string in Web.config
        {
        }
    }
}