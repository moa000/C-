using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program pgm = new Program();
            //int != pgm.function();
            Test01 Sub = new Test01();
            Sub.MainFunc();
            
        }
        int function() 
        { 
            while (true) 
            {
            
            }
            return 1; 
        }
    }
}
    class Test01
    {
        public Test01()
        {
        Console.WriteLine("Hello World!");
        }

        public void MainFunc()
        {

        var v = 100;
        int i = 10, j = 20;
        double d = 1.5, e = 3.1;
        Object o = i +1;
        Console.WriteLine("Hello World{0},{1},{5}\n Main Function{2},{3}", i, j,d,e,o);
        o = d + 0.5;
        Console.WriteLine("Hello World{0},{1}\n Main Function{2},{3}", i, j, d, e, o);

        /*
                string str = Console.ReadLine();
                i = int.Parse(str.Split(' ')[0]);
                j = int.Parse(str.Split(' ')[1]);

                string str1 = Console.ReadLine();
                d = int.Parse(str1.Split(' ')[0]);
                e = int.Parse(str1.Split(' ')[1]);
                Console.WriteLine($"Hello World{d},{e}\n Main Function{e},{d}");*/
        while (true)
        {
            try
            {
                WriteLine("두 개의 정수를 입력하세요");
                string str = Console.ReadLine();
                i = int.Parse(str.Split(' ')[0]);
                j = int.Parse(str.Split(' ')[1]);
                Console.WriteLine($"Hello World{d},{e}\n Main Function{e},{d}");

                WriteLine("두 개의 실수를 입력하세요");
                string st1 = Console.ReadLine();
                d = double.Parse(st1.Split(' ')[0]);
                e = double.Parse(st1.Split(' ')[1]);
                Console.WriteLine($"Hello World{d},{e}\n Main Function{e},{d}");

            }
            catch
            {
                WriteLine("e1.Message");

            }
        }

        /* Console.WriteLine("Main Function\n");
         Console.WriteLine("Hello World{0},{1}\n Main Function{0},{1}",i,j);
         Console.WriteLine($"Hello World{i},{j}\n Main Function{d},{e}");
         Console.ReadLine(); 
         string str = "STX" + i.ToString() + "ETX";
         string st1 = $"STX{i,5}ETX";
         WriteLine(str);
         Console.WriteLine(st1);*/

    }
}
