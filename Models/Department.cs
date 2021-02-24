using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeMgmt
{ 
    public class Department
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(255)]
        public string Location { get; set; }

        public ICollection<Employees> Employees { get; set; } = new List<Employees>();
        
        
    }
}