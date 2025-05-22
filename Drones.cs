using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    class Drones : Attack_options
    {
        private string _name = "Drone unit";
        private static int _amount_of_Drones;
        private int _amount_of_Patterns = 3;

        public Drones(int amount_of_fule)
        {
            _amount_of_Drones++;
            _amount_of_fuel = amount_of_fule;
            Idf.setattack_capabilities(this);
        }

        public override string EffectiveAgainst()
        {
            return "Armored or people";
        }
        public override string TypeOfBombs()
        {
            return "all kinds ";
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
