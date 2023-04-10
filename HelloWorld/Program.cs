using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕 세상아");
            char a = 'a';
            Console.WriteLine(a);   // 와 자동완성...
            string b = "b";
            Console.WriteLine(b);   // 와... 자동완성...

            foreach(var arg in args) Console.WriteLine(arg);
        }
    }
}
