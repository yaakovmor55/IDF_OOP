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
achiya_AMAN_-and_reports
        private DateTime _date;
        private string _message;

        public Report(Terrorist terrorist, string location, string date, string message)
        {
            _terrorist = terrorist;
            _location = location;
            _date = DateTi
        private DateTime _date = DateTime.Now;
        private string _message;

        public Report(Terrorist terrorist, string location, string message)
        {
            _terrorist = terrorist;
            _location = location;
            
 main
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


        public DateTime GetDate()
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
