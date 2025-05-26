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
        protected static int _globalId = 1;
        protected int _id;
        //protected int _amount_of_ammunition;

        public abstract string EffectiveAgainst();
        public abstract string TypeOfBombs();
        public abstract int GetAvailableAttackPatterns();

        public abstract void SetAvailableAttackPatterns();
        public abstract bool IsAvailable();
        public abstract string GetName();

        public abstract int GetID();



    }

}
