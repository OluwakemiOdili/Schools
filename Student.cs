using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DateOfBirth { get; set; }   
        public ICollection<Student> StudentDetails { get; set; }

    }

    public class Studentdetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int studentID { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int StudentID { get; set; }

        [ForeignKey("StudentsID")]
        public Student student { get; set; }    


    }
}
