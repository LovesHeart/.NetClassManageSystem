using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            Console.WriteLine("课程的名称："+name);
            Console.WriteLine("课程周次是" +wqj1.from+"-"+wqj1.to+"周" );
            Console.WriteLine("课程是星期" +day1+"的第"+day1Time+"节课"+"上课" );
        }
    }

    class Program
    {

        List<Class> listClass = new List<Class>();
        static void Main(string[] args)
        {
            Class newclass=new Class();
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
            newclass.Display();
            Console.ReadLine();//暂停下
        }
    }
}
