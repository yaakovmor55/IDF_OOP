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
            Terrorist terrorist = new Terrorist("aa", "4", "l", "g", "out");
            Hamas.GetListOfTerrorists().Clear();
            Console.WriteLine(Hamas.GetListOfTerrorists()[0].Getname());
        }
    }
}
