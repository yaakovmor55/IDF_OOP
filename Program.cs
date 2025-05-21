using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Idf.Getattack_capabilities();
            Console.WriteLine(Idf.Getattack_capabilities()[0]);
        }
    }
}
