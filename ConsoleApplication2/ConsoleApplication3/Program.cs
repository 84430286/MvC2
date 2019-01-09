using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.SchoolinLayer;
using ConsoleApplication3.Models;
using ConsoleApplication3.DataAccessLayer;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //crateGrade();

            QueryBlog();
            //Updata();
            //Delete();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
        static void crateGrade()
        {
            Console.WriteLine("请输入班级");
            string name = Console.ReadLine();
            Grade grade = new Grade();
            grade.Gradename = name;
           
           SchoolLayer scl = new SchoolLayer();
            scl.Add(grade);

        }
        static void QueryBlog()
        {
            SchoolLayer scl = new SchoolLayer();
            var grades = scl.Query();
            foreach (var item in grades)
            {
                Console.WriteLine(item.GradeId + " " + item.Gradename);
            }
        }
        static void Updata()
        {
            SchoolLayer scl = new SchoolLayer();
            Console.Write("输入班级id");
            int id = int.Parse(Console.ReadLine());
            Grade grade = scl.Query(id);
            Console.Write("输入新名字");
            string name = Console.ReadLine();
            grade.Gradename = name;
            scl.Update(grade);
        }
        static void Delete()
        {
            SchoolLayer scl = new SchoolLayer();
            Console.Write("请输入删除的班级id");
            int id = int.Parse(Console.ReadLine());
            Grade grade = scl.Query(id);
            scl.Delete(grade);
        }
    }
}
