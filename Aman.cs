using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    internal static class Aman
    {
        private static List<Report> _reportsList = new List<Report>();

        public static void AddReport(Report newreport)
        {
            _reportsList.Add(newreport);
        }
        public static List<Report> GetReportsOfTerrorits(Terrorist terrorist)
        {
            if (_reportsList.Count == 0) return new List<Report>();
            List<Report> result = new List<Report>();

            

            foreach (Report report in _reportsList)
            {
                if (report.GetTerrorist() == terrorist)
                {
                    result.Add(report);
                }

            }
 
            return result;
        }
        public static Report GetLastReport(List<Report> listreports)
        {
            if (listreports == null  || listreports.Count==0) return null;
            return listreports[listreports.Count - 1];
        }

        public static List<Report> GetValidReports()
        {
            
            DateTime now = DateTime.Now;
            return _reportsList.Where(report => (now - report.GetDate()).TotalHours <= 24).ToList();
        }









    }
}
