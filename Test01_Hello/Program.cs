using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test01_Hello;

namespace Test01_Hello
{
    static class myLib
    {
        public static string GetToken(string str, int n, char ch)
        {
            return str.Split(ch)[n];
        }
    }

    class Point
    {
        int x, y;
        public Point(int x=0, int y = 0) 
        {
        this.x = x;
        this.y = y;
        }

        public double Dist(Point p1)
        {
            int d1 = p1.x - x;
            int d2 = p1.y - y;
            return Math.Sqrt(d1*d1 + d2*d2);
        }

        public static double operator - (Point p1,Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }

        public static double operator * (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Abs(d1 * d2);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Program pgm = new Program();
            //int != pgm.function();
            Test01 Sub = new Test01();
            Sub.MainFunc();

        }       
    }
}
    class Test01
    {


        public void Func1()
        {
            Point p = new Point(10, 20);
            Point p1 = new Point(30, 40);
            Console.WriteLine($"p1(10,20)과 P(30,40)의 거리는 DIST[ [{(p1-p)}:F2] 입니다.");
            Console.WriteLine($"p1(10,20)과 P(30,40)를 대각선으로 하는 면적은 [ {(p1 * p)}] 입니다.");

            string s1 = "Good";
            string s2 = "morning";
            string s3 = s1 + s2;
        }

        public void MainFunc()
         {
        //Func1(); return;
        var v = 100;
        int i = 10, j = 20;
        double d = 1.5, e = 3.1;
        Object o = i + 1;
        var v = i * 10;

        Console.WriteLine("Hello World{0},{1},{4},{5}\n Main Function{2},{3}", i, j, d, e, o, v);
        o = d + 0.5;
        v = j * 10;

        Console.WriteLine("Hello World{0},{1}\n Main Function{2},{3},{4}", i, j, d, e, o);
        Console.WriteLine("i:{0},j:{1},d:{2},e:{3},o:{4}");
        Console.WriteLine("i:{0},j:{1},d:{2},e:{3},o:{4}");


        int [] arr = new int[i];
        for (int i1 = 0; i1 < 10; i1++) arr[i1] = i1;
        arr[1].



        //myLib my = new myLib();
        //while(true)



        string str = Console.ReadLine();
        i = int.Parse(str.Split(' ')[0]);
        j = int.Parse(str.Split(' ')[1]);

        string str1 = Console.ReadLine();
        d = int.Parse(str1.Split(' ')[0]);
        e = int.Parse(str1.Split(' ')[1]);
        Console.WriteLine($"Hello World{d},{e}\n Main Function{e},{d}");
        while (true)
        {
            try
            {
                WriteLine("두 개의 정수를 입력하세요");
                string str = Console.ReadLine();
                // i = int.Parse(str.Split(' ')[0]);
                i = int.Parse(myLib.GetToken(str, 0, ' '));
                j = int.Parse(str.Split(' ')[1]);
                Console.WriteLine($"입력한 정수는 {i},{j}");

                WriteLine("두 개의 실수를 입력하세요");
                string st1 = Console.ReadLine();
                d = double.Parse(st1.Split(' ')[0]);
                e = double.Parse(st1.Split(' ')[1]);
                Console.WriteLine($"Hello World{d},{e}");

            }
            catch
            {
                WriteLine("e1.Message");

            }
        }

        Console.WriteLine("Main Function\n");
        Console.WriteLine("Hello World{0},{1}\n Main Function{0},{1}", i, j);
        Console.WriteLine($"Hello World{i},{j}\n Main Function{d},{e}");
        Console.ReadLine();
        string str = "STX" + i.ToString() + "ETX";
        string st1 = $"STX{i,5}ETX";
        WriteLine(str);
        Console.WriteLine(st1);

    }
}
