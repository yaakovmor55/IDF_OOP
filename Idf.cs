using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    static class Idf
    {
        private static string _date_of_establishment = "26/05/1948";
        private static string _name_of_commander;
        private static List<string> _attack_capabilities = new List<string>() { "Fighter_jets", "artillery", "drones" };

        public static string Getdate_of_establishment()
        {
            return _date_of_establishment;
        }
        public static string Getname_of_commander()
        {
            return _name_of_commander;
        }
        public static void Setname_of_commander(string name)
        {
            _name_of_commander = name;
        }
        public static List<string> Getattack_capabilities()
        {
            return  new List<string>(_attack_capabilities); 
        }
        public static void  setattack_capabilities(string nameof)
        {
            _attack_capabilities.Add(nameof);
        }

    }
}
