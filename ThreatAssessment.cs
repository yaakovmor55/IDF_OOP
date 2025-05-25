using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_OOP
{
    internal static class ThreatAssessment
    {
        public static Terrorist GetMostReportedTerrorist(List<Terrorist> listterrorist)
        {
            if (listterrorist == null || listterrorist.Count == 0)
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

        public static Terrorist GetMostDangerousTerrorist(List<Terrorist> listTerrorists)
        {
            if (listTerrorists == null || listTerrorists.Count == 0) return null;
            Terrorist mostDangerous = listTerrorists[0];
            int maxScore = QualityRatingOfaTerrorist(mostDangerous);

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

        public static int QualityRatingOfaTerrorist(Terrorist terrorist)
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
                    default:
                        Console.WriteLine($"Unknown weapon: {weapon}"); 
                        break;
                        

                }
            }
            return score * terrorist.GetRank();
        }

        public static string GetAllInformation(Terrorist terrorist)
        {

            List<Report> reportList = Aman.GetReportsOfTerrorits(terrorist);
            Report last = Aman.GetLastReport(reportList);

            string location = "No location information";
            string time = "There is no reporting time";
            string message = "There are no reports";
            if (last != null)
            {
                location = last.GetLocation();
                time = last.GetDate().ToString("dd/MM/yyyy HH:mm");
                message = last.GetMessage();
            }

            int quality = QualityRatingOfaTerrorist(terrorist);
            return $"{terrorist.GetTerroristDetaild()}\n" +
            $"amount of reports: {reportList.Count}\n" +
            $"last location: {location}\n" +
            $"lass date report: {time}\n" +
            $"last message: {message}\n"+
            $"Threat Score: {quality}";


        }
    }
}
