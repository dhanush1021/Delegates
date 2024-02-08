using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int Addnumber(int num1, int num2);
    public delegate string AddString(string str1, string str2);

    class prog
    {
        public int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }
        public string AddString(string str2, string str1)
        {
            return str1 + str2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            prog prog = new prog();
            Addnumber del = new Addnumber(prog.AddNumber);
            int num = del(3, 4);
            Console.WriteLine(num);
        }
    }
}
