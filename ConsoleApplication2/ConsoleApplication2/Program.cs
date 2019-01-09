using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication5.Models;
using ConsoleApplication2.DataAccessLayer;
using ConsoleApplication2.BlogBusinessLayer;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("博客列表");
            //crateBlog();
            //QueryBlog();
            AddPost();
            //Console.WriteLine("选择功能：1--增加博客   2--删除博客   3--修改博客  4--操作帖子");
            //int a = int.Parse(Console.ReadLine());
            //if (a == 1)
            //{
            //    crateBlog();

            //}
            //else if (a == 2)
            //{
            //    Delete();
            //}
            //else if (a == 3)
            //{
            //    Update();
            //}
            //else if (a == 4)
            //{
            //    Console.Clear();

            //    int bolgid = GetbolgId();

            //    Dispaypost();
            //    Console.WriteLine("1--增加帖子  2--删除帖子  3--修改帖子");
            //    if (a == 1)
            //    {
            //        carpost();
            //    }
            //    else if (a == 2)
            //    {
            //        DeletePost();
            //    }
            //    else if (a == 3)
            //    {
            //        Addpost(bolgid);
            //    }




            //}
            //else if (a == 5)
            //{
            //    Console.Clear();
            //    return;
            //}

            //Console.WriteLine("按任意键退出");
            //Console.ReadKey();
            sw();



        }
        static void sw()
        {
            Console.WriteLine(" 1--新增博客  2--删除博客   3--更新博客  4--查找博客帖子 5--查询帖子");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:

                    crateBlog();
                    Console.Clear();
                    AddPost();
                    sw();
                    break;
                case 2:
                    Delete();

                    Console.Clear();
                    AddPost();
                    sw();
                    break;
                case 3:
                    Update();
                    Console.Clear();
                    AddPost();
                    sw();
                    break;
                case 4:
                    int bolgid = GetbolgId();
                    Console.WriteLine("1--新增帖子 2--更改贴子 3--删除帖子 4--返回博客");
                    int b = int.Parse(Console.ReadLine());
                    switch (b)
                    {
                        case 1:


                            carpost();
                            Console.Clear();
                            Dispaypost();
                            sw();
                            break;
                        case 2:

                            Addpost(bolgid);
                            Console.Clear();
                            DisplayBlog(bolgid);
                            sw();
                            break;
                        case 3:
                            DeletePost();

                            Console.Clear();
                            Dispaypost();
                            sw();
                            break;
                    }
                    break;
                case 5:
                    Querbolgname();
                    break;
            }
        }
        static void AddPost()
        {
            //显示博客列表
            QueryBlog();
            //用户选择某个博客（id）
              //int bolgid= GetbolgId();


            //显示指定博客的帖子列表
            //DisplayBlog(bolgid);

            //根据指定到博客信息创建新帖子       
            //Addpost(bolgid);
            //显示全部帖子
            //Dispaypost();
            // 删除
           
            //DeletePostid(bolgid);
            //DeletePost();
        }
        static void Querbolgname()
        {
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.WriteLine("输入博客名");
            //Blog blog = new Blog();
            
            string blogs = Console.ReadLine();
            //blog.Name = blogs;
            var quer= bbl.Querypost(blogs);
            foreach (var item in quer)
            {
                Console.WriteLine(item.Title + "" + item.Content);
                Console.Read();
            }
            
            


        }
        static int GetbolgId()
        {
            //BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.Write("输入博客id");
            int id = int.Parse(Console.ReadLine());
            return id;
            //Blog bolg = bbl.Query(id);
           
        }
        static void DisplayBlog(int bolgid)
        {

            //BlogBusinessLayers bbl = new BlogBusinessLayers();
            //Blog bolg = bbl.Query(bolgid);
            //Console.WriteLine(bolg.Name);

            //var post= bbl.QueryPost();
            // foreach (var item in post)
            // {        
            //      Console.WriteLine("博客号：",item.Title+""+"博客内容",item.Content)
            // }
            //var list = bolg.Posts;



            Console.WriteLine(bolgid + "帖子");
            List<Post> list = null;
            //根据博客id获取博客
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(bolgid);
                list = blog.Posts;

            }
            //遍历所有帖子
            foreach (var item in list)
            {
                Console.WriteLine("帖子 id："+item.Blog.BlogId +"帖子标题：" +item.Content+"    帖子内容： " + item.Title);
            }



        }
        //显示全部帖子
        static void Dispaypost()
        {
            BlogBusinessLayers bll = new BlogBusinessLayers();
            var post = bll.QueryPost();
            foreach (var item in post)
            {
                Console.WriteLine("贴子id"+ item.PostId + "   帖子标题" + item.Title);
            }
        }
        static void DeletePost()
        {
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.Write("请输入删除的帖子的id");
            //int id = int.Parse(Console.ReadLine());
            //Post post = new Post();
            int boid= int.Parse(Console.ReadLine());

            //post.BlogId = boid;

            Post posts = bbl.Query2(boid);
            bbl.Delete2(posts);

        }
        //static void DeletePostid(int bolgid)
        //{
        //    BlogBusinessLayers bbl = new BlogBusinessLayers();
        //    Console.Write("请输入删除的帖子的id");
        //    //int id = int.Parse(Console.ReadLine());
        //    Post post = new Post();
        //    bolgid = int.Parse(Console.ReadLine());

        //    post.BlogId = bolgid;

        //    Post posts = bbl.Query2(bolgid);
        //    bbl.Deleteboid(bolgid);
        //}
        static void Addpost(int bolgid)
        {

            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.Write("输入博客id");
            Post post = new Post();
            post.BlogId = bolgid;
            //int id = int.Parse(Console.ReadLine());
            // Blog blog = bbl.Query(id);
            
            Console.WriteLine("输入新帖子title");
            
            string title = Console.ReadLine();
            Console.WriteLine("输入新帖子Content");
            string content = Console.ReadLine();
            
            post.Title = title;
            post.Content = content;
            //blog.Name = title;
            bbl.Addpost(post);
            DisplayBlog(bolgid);

        }
        static void carpost()
        {
            Console.WriteLine("请输入帖子");
            string name = Console.ReadLine();
            Post post = new Post();
            Console.WriteLine("输入新帖子title");

            string title = Console.ReadLine();
            Console.WriteLine("输入新帖子Content");
            string content = Console.ReadLine();

            post.Title = title;
            post.Content = content;
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            bbl.Addpost(post);
        }
        
      // 创建博客
        static void crateBlog()
        {
            Console.WriteLine("请输入博客");
            string name = Console.ReadLine();
            Blog blog = new Blog();
            blog.Name = name;
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            bbl.Add(blog);
            
        }
        //检索博客
        static void QueryBlog()
        {
            BlogBusinessLayers bll = new BlogBusinessLayers();
            var blogs = bll.Query();
            foreach (var item in blogs)
            {
                Console.WriteLine(item.BlogId + " " + item.Name);
            } 
        }
        //修改博客
        static void Update()
        {
            
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.Write("输入博客id");
            int id = int.Parse(Console.ReadLine());
            Blog bolg = bbl.Query(id);
            Console.Write("输入新名字");
            string name = Console.ReadLine();
            bolg.Name = name;
            bbl.Update(bolg);
        }
        //删除博客
        static void Delete()
        {
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.Write("请输入删除的博客id");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);
        }
    }
}
