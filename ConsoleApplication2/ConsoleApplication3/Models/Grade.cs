using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Models
{
   public class Grade
    {
        public string Gradename { get; set; }
        public int GradeId { get; set; }
        public virtual List<Student> Student { get; set; }
    }
}
