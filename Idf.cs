using System;
using System.Collections;
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
        private static Dictionary<string, List <Attack_options>> _units = new Dictionary<string, List<Attack_options>>();

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

        public static void  setattack_capabilities(Attack_options AttackTool)
        {
            if (!_units.ContainsKey(AttackTool.GetName()))
            {
                _units[AttackTool.GetName()] = new List<Attack_options>();
            }
            _units[AttackTool.GetName()].Add(AttackTool);
        }

        public static string GetAllAttackUnitsDetails()
        {
            if (_units == null ||  _units.Count == 0)return null;
            string result = "##### Information about the attack tool #####\n";
            foreach (var unit in _units)
            {
                result += $" unit type: {unit.Key}\n" +
                    $" total: {unit.Value.Count}\n";
                

                foreach(Attack_options attacktool in unit.Value)
                {
                    result += $"    ID : {attacktool.GetID()}\n";
                    result += $"    Available: {attacktool.IsAvailable() }\n";
                    result += $"    Bomb Type: {attacktool.TypeOfBombs()}\n";
                    result += $"    Patterns Left: {attacktool.GetAvailableAttackPatterns()}\n";
                    result += $"    Effective Against: {attacktool.EffectiveAgainst()}\n";
                   
                }
                result += "\n";
               
            }
            return result;
        }

    }
}
