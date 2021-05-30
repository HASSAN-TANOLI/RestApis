using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {

        }


    public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Jhon",
                LastName = "Pablo",
                Email = "jhonpablo@gmail.com",
                DOB = new DateTime(1980, 04, 10),
                PhoneNumber = "0331223343"
            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Adam",
                LastName = "Salah",
                Email = "adamsalah@gmail.com",
                DOB = new DateTime(1990, 08, 14),
                PhoneNumber = "0311223334"
            });
        }
    }
}
