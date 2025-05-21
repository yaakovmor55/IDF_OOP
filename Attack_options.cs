using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    internal abstract class Attack_options
    {
        protected int _amount_of_fuel;
        protected int _amount_of_ammunition;

        public abstract string EffectiveAgainst();
        public abstract string TypeOfBombs();
        public abstract int GetAvailableAttackPatterns();

        public abstract void SetAvailableAttackPatterns();

    }
    class Plane : Attack_options
    {
        private static int _amount_of_plane;
        private int _amount_of_Patterns=8;

        public Plane (int amount_of_fule)
        {
            _amount_of_plane ++ ;
            _amount_of_fuel = amount_of_fule ;
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
    }

    class Artillery : Attack_options
    {
        private static int _amount_of_Artillery;
        private int _amount_of_Patterns = 40;

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
        
    }

    class Drones : Attack_options
    {
        private static int _amount_of_Drones;
        private int _amount_of_Patterns = 3;

        public Drones(int amount_of_fule)
        {
            _amount_of_Drones ++;
            _amount_of_fuel = amount_of_fule;
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

    }

}
