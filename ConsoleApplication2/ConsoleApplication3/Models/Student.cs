using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Models
{
   public class Student
    {
        public string Stname { get; set; }
        public int StudentID { get; set; }
        //public int ClassId { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade  { get; set; }
    }
}
