using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    public static class Hamas
    {
        private static string _DateOfEstablishment = "1988";
        private static string _HamasCommander = "Muhammad Sanwar";
        private static List<Terrorist> _ListOfTerrorists = new List<Terrorist>();

        public static void SetDateOfEstablishment(string dateOfEstablishment)
        {
            _DateOfEstablishment = dateOfEstablishment;
        }
        public static string GetDateOfEstablishment()
        {
            return _DateOfEstablishment;
        }
        public static void SetHamasCommander(string hamasCommander)
        {
            _HamasCommander = hamasCommander;
        }
        public static string GetHamasCommander()
        {
            return _HamasCommander;
        }

        public static void AddTerrorist(Terrorist terrorist)
        {
            _ListOfTerrorists.Add(terrorist);
        }
        public static List<Terrorist> GetListOfTerrorists()
        {
            return new List<Terrorist>(_ListOfTerrorists);
        }








    }
}
