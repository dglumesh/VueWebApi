using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string MiddleName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Mobile { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Telephone { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(350)")]
        public string Address { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string NIC { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
