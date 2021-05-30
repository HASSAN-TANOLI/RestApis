using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public long EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DOB { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
    }
}
