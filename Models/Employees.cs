using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeMgmt
{ 
    //[Table("tblEmployees")]
    public class Employees
    {
        public int Id { get; set; }
        
        [Column("First_Name")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Gender {get; set;}

        public int Salary {get; set;}

        public int DepartmentId { get; set;}

        public Department Department { get; set; }

        //public string JobTitle { get; set; }
        
    }
}