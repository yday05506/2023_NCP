using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("안녕 세상아");
            //char a = 'a';
            //Console.WriteLine(a);   // 와 자동완성...
            //string b = "b";
            //Console.WriteLine(b);   // 와... 자동완성...

            //foreach(var arg in args) Console.WriteLine(arg);


            // API 연습
            //Console.Write("메서드 호출");
            //Thread.Sleep(1000);
            //Console.SetCursorPosition(5, 5);
            //Console.Write("메서드 호출2");
            //Thread.Sleep(2000);
            //Console.SetCursorPosition(2, 2);
            //Console.Write("메서드 호출3");
            // Console.SetCursorPosition(5, 5);

            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if(x % 3 == 0)
                    Console.WriteLine("__@");
                else if(x%3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
