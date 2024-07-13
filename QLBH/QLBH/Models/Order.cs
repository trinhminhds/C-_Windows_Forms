using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("OrderID")]
    internal class Order
    {
        public long OrderID { get; set; }
        [Column(TypeName = ("Date"))]
        public DateTime OrederDate { get; set; }
        public DateTime OrederTime { get; set; }
        [Column(TypeName = ("Date"))]
        public DateTime ReceiveDate { get; set; }
        public DateTime ReceiveTime { get; set; }
        [StringLength(250),Column(TypeName = "NVARCHAR(100)")]
        public string ReceiveAddress { get; set; }
        public byte ProgressID { get; set; } 
        public long CustomerID { get; set; }
        [StringLength(8)]
        public string EmployeeID { get; set; }
        public virtual Employee Employee { get; set; } 
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
