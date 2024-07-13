using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("PersonID")]
    internal class Person
    {
        public long PersonID { get; set; } //bigint, identity(1,1), PK
        [StringLength(100)]
        public string Name { get; set; } //nvarchar(100), not null
        public bool? Gender { get; set; } //bit, null
        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; } //date, not null
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; } //nchar(10), not null
        [StringLength(100)]
        public string? Email { get; set; } //nvarchar(100), null
        public bool Status { get; set; } //bit, not null
        public virtual Employee Employee { get; set; } = null;
        public virtual Customer Customer { get; set; } = null;

    }
}
