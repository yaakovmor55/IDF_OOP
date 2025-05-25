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
            List<Report> result = new List<Report>();
            foreach (Report report in _reportsList)
            {
                if (report.GetTerrorist() == terrorist)
                {
                    result.Add(report);
                }

            }
            if (result.Count == 0)
            {
                Console.WriteLine("no reports");
            }
            return result;
        }
        public static Report GetLastReport(List<Report> listreports)
        {
            return listreports[listreports.Count - 1];
        }
        public static Terrorist GetMostReportedTerrorist(List<Terrorist> listterrorist)
        {
            if (listterrorist.Count == 0)
            {
                return null;
            }
            Terrorist terrorist = listterrorist[0];

            foreach (Terrorist tr in listterrorist)
            {
                if (Aman.GetReportsOfTerrorits(tr).Count > Aman.GetReportsOfTerrorits(terrorist).Count)
                {
                    terrorist = tr;
                }
            }
            return terrorist;
        }

        public static List<Report> GetValidReports()
        {
            DateTime now = DateTime.Now;
            return _reportsList.Where(report => (now - report.GetDate()).TotalHours <= 24).ToList();
        }

        public static Terrorist GetMostDangerousTerrorist(List<Terrorist> listTerrorists)
        {
            Terrorist mostDangerous = listTerrorists[0];
            int maxScore =QualityRatingOfaTerrorist(mostDangerous);

            foreach (Terrorist tr in listTerrorists)
            {
                int currentScore = QualityRatingOfaTerrorist(tr);
                if (currentScore > maxScore)
                {
                    mostDangerous = tr;
                    maxScore = currentScore;
                }
            }
            return mostDangerous;

        }
        public static  int QualityRatingOfaTerrorist(Terrorist terrorist)
        {
            int score = 0;
            foreach (string weapon in terrorist.GetWeapon())
            {
                switch (weapon.ToLower())
                {
                    case "knife":
                        score += 1;
                        break;
                    case "gun":
                        score += 2;
                        break;
                    case "ak47":
                    case "m16":
                        score += 3;
                        break;
                }
            }
            return score * terrorist.GetRank();
        }




    }
}
