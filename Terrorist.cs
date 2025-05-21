using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    public class Terrorist
    {
        private string _name;
        private string _rank;
        private string _status;
        private string _weapon;
        private string _location;

        public Terrorist(string name, string rank, string status, string weapon, string location)
        {
            _name = name;
            _rank = rank;
            _status = status;
            _weapon = weapon;
            _location = location;

            Hamas.AddTerrorist(this);
            
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public string Getname()
        {
            return _name;
        }

        public void SetRank(string rank)
        {
            _rank = rank;
        }
        public string GetDateOfEstablishment()
        {
            return _rank;
        }

        public void SetStatus(string status)
        {
            _status = status;
        }

        public string GetStatus()
        {
            return _status;
        }

        public void SetWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public string GetWeapon()
        {
            return _weapon;
        }

        public void SetLocation(string location)
        {
            _location = location;
        }

        public string GetLocation()
        {
            return _location;
        }

        

    }

    

}
