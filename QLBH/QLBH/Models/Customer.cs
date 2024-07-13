using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("CustomerID")]
    internal class Customer
    {
        public long CustomerID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime JoinDate { get; set; }
        public Person PersonID { get; set; }
        public virtual Person Person { get; set; } = null;
        public virtual ICollection<Order> Orders { get; set; }

    }
}
