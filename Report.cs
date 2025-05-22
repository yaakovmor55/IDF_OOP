using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    internal class Report
    {
        private Terrorist _terrorist;
        private string _location;
        private string _date;
        private string _message;

        public Report(Terrorist terrorist, string location, string date, string message)
        {
            _terrorist = terrorist;
            _location = location;
            _date = date;
            _message = message;

        }

  
        public Terrorist GetTerrorist()
        {
            return _terrorist;
        }
        public void SetLocation(string location)
        {
            _location = location;
        }
        public string GetLocation()
        {
            return _location;
        }

        public void SetDate(string date)
        { 
            _date = date;
        }
        public string GetDate()
        {
            return _date;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
        public string GetMessage()
        {
            return _message;
        }




    }
}
