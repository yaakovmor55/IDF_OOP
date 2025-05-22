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
        private int _rank;
        private string _status;
        private string _PersonalNumber;
        private List<string>_weapon = new List<string>();


        public Terrorist(string name, int rank, string status, string weapon, string personalNumber)
        {
            _name = name;
            _rank = rank;
            _status = status;
            _weapon.Add(weapon);
            _PersonalNumber = personalNumber;


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

        public void SetRank(int rank)
        {
            if (rank < 6 && rank > 0) _rank = rank;
            else Console.WriteLine("Ranks must be between 1 and 5!");

        }
        public int GetRank()
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
            _weapon.Add(weapon);
        }
        public List<string> GetWeapon()
        {
            return new List<string>(_weapon);
        }

        public void SetPersonalNumber(string personalNumber)
        {
            _PersonalNumber = personalNumber;
        }
        public string GetPersonalNumber()
        {
            return _PersonalNumber;
        }

        public string GetTerroristDetaild()
        {
            return $"Name: {this.Getname()}\nRank: {this.GetRank()}\nPersonal Number: {this.GetPersonalNumber()}\nStatus: {this.GetStatus()}";
        }
       

        

    }

    

}
