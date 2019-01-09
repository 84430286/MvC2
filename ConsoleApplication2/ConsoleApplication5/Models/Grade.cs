using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Models
{
   public class Grade
    {
        
        public int ClassId { get; set; }
        public string Classname { get; set; }
        public virtual List<Student> Student { get; set; }

    }
}
