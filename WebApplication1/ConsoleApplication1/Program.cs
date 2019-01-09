using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //class Test<T>
        //{
        //    public T obj;
        //    public Test(T obj)
        //    {
        //        this.obj = obj;
        //    }
        //}
        static void Main(string[] args)
        {
            //int numb = 2;
            //var test = new Test<int>(numb);
            //Console.WriteLine(test.obj);

            //string obj2 = "hello,world!";
            //var test1 = new Test<string>(obj2);
            //Console.WriteLine(test1.obj);


            //Console.Read();



            var fru = new List<Fruit>();
             Fruit fru2 = new Fruit();
            fru2.Fru = "苹果";
            fru2.Price = 2.5;
            fru.Add(fru2);

            foreach (var item in fru)
            {
                Console.WriteLine("果名：{0},价格{1}", item.Fru, item.Price);
            }
            Console.Read();
        }
    }
}
