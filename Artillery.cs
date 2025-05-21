using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    class Artillery : Attack_options
    {
        private static int _amount_of_Artillery;
        private int _amount_of_Patterns = 40;
        private string _name = "Artillery unit";

        public Artillery(int amount_of_fule)
        {
            _amount_of_Artillery++;
            _amount_of_fuel = amount_of_fule;
        }

        public override string EffectiveAgainst()
        {
            return "open spaces";
        }
        public override string TypeOfBombs()
        {
            return "shells ";
        }
        public override int GetAvailableAttackPatterns()
        {
            return _amount_of_Patterns;
        }
        public override void SetAvailableAttackPatterns()
        {
            _amount_of_Patterns--;
        }
        public override bool IsAvailable()
        {
            return _amount_of_fuel > 0 && _amount_of_Patterns > 0;
        }
        public override string GetName()
        {
            return _name;
        }

    }
}
