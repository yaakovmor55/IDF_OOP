using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    class Plane : Attack_options
    {
        private string _name = "Plane unit";
        private static int _amount_of_plane;
        private int _amount_of_Patterns = 8;

        public Plane(int amount_of_fule)
        {
            _amount_of_plane++;
            _amount_of_fuel = amount_of_fule;
            Idf.setattack_capabilities(this);
        }

        public override string EffectiveAgainst()
        {
            return "build";
        }
        public override string TypeOfBombs()
        {
            return " 1 ton or 0.5 ton";
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
