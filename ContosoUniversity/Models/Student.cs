using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}