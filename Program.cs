using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int Addnumber(int nu, int nu2);
   // public delegate string AddString(string str1, string str2);

    class prog
    {
        public int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }
        public int AddString(int str2, int str1)
        {
            return str2 * str1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            prog prog = new prog();
            Addnumber del = new Addnumber(prog.AddNumber);
            int num = del(3, 4);
            del += prog.AddString;
            int num2 = del(5, 6);
            del += prog.AddNumber;
            int num3 = del(6, 7);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
