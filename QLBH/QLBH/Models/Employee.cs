using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("EmployeeID")]
    internal class Employee
    {
        public long EmployeeID { get; set; }
        public string DepartmentID { get; set; }
        public long PersonID { get; set; }
        public string UserID { get; set; }
        public virtual Person Person { get; set; } = null;
        public virtual ICollection<Order> Orders { get; set; }

    }
}
