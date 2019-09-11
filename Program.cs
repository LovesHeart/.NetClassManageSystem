using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManageSystem
{
    public class BasicFuctions
    {
        public int ReadInt()
        {
            //int t=Console.Read();
            //if (t >= 48 && t <= 57) return t - 48;
            //else return ReadInt();
            int x = 0, f = 1;
            int ch = Console.Read();
            while (ch < '0' || ch > '9')
            {
                if (ch == '-')
                    f = -1;
                ch = Console.Read();
            }
            while (ch >= '0' && ch <= '9')
            {
                x = (x << 1) + (x << 3) + (ch ^ 48);
                ch = Console.Read();
            }
            return x * f;
        }
    }
    class WeekQuJian
    {
        public int from;
        public int to;
    }
    public class Class
    {
        //FileStream F, Fin;
        //public void init()
        //{
        //    F = new FileStream("out.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    Fin = new FileStream("in.txt", FileMode.Open, FileAccess.Read);
        //}
        public string name;
        //public
        public int day1Time;//每天的第几节课从1,2-9,10or1-5
        public int day2Time;
        public int day1;
        public int day2;//每周最多2天同一节课,1-7
        WeekQuJian wqj2;
        WeekQuJian wqj3;
        WeekQuJian wqj1;
        public void ReadName()
        {
            string t = Console.ReadLine();
            if(t=="")t= Console.ReadLine();
            //string t = Fin.CanRead();
            name = t;
        }
        public void ReadWqj()
        {
            //int t1 = Convert.ToInt32(Console.Read());
            //int t2 = Convert.ToInt32(Console.Read());// Convert.ToInt32()
            BasicFuctions bf = new BasicFuctions();
            int t1 = bf.ReadInt();
            int t2 = bf.ReadInt();
            wqj1 = new WeekQuJian();//刚才报错为wqj1是null
            wqj1.from = t1;
            wqj1.to = t2;
        }
        public void Display()
        {
            Console.WriteLine("课程的名称：" + name);
            Console.WriteLine("课程周次是" + wqj1.from + "-" + wqj1.to + "周");
            Console.WriteLine("课程是星期" + day1 + "的第" + day1Time + "节课" + "上课");
        }
    }
    public class Program
    {
        public List<Class> listClass = new List<Class>();
        static void Main(string[] args)
        {
            //public List<Class> listClass = new List<Class>();
            Console.WriteLine("如果您想要录入新的课程,请输入：1");

            int ans;//表示是否录入新的课程
            ans = Console.Read() - 48;

            //int aabb = int.Parse("1");//c#超严格不能char直接转1的intASCII码49

            Program program = new Program();

            while (ans == 1)
            {
                Class newclass = new Class();
                //newclass.init();
                Console.WriteLine("请输入您要录入的课程的名称：");
                //listClass.Add()
                //newclass   =Console.ReadLine();
                newclass.ReadName();
                Console.WriteLine("请输入您要录入的课程的对应周次：");
                newclass.ReadWqj();
                Console.WriteLine("请输入您要录入的课程的对应周次的周几上课：");
                BasicFuctions bf = new BasicFuctions();
                newclass.day1 = bf.ReadInt();
                Console.WriteLine("请输入您要录入的课程的对应周次的周几的第几节课上课：");
                newclass.day1Time = bf.ReadInt();
                program.listClass.Add(newclass);

                //newclass.Display();

                //Console.ReadLine();//暂停下
                /*
                现在的目的是:能够循环使用以上结构,构建数据库
                */
                //ans = Console.Read();
                Console.WriteLine("如果您想要录入新的课程,请输入：1");
                ans = Console.Read();
            }
            foreach(var i in program.listClass)
            {
                i.Display();
            }
        }
    }
}
