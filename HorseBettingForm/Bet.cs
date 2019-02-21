using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace HorseBettingForm
{
    public class Bet
    {

        public string Course { get; set; }
        
        public DateTime Date { get; set; }
        
        public double Amount { get; set;}

        public string IfWin { get; set; }

    

    public Bet()
    {

    }
    public Bet(string course, DateTime date, double amount, string win)
    {
            Course = course;
            Date = date;
            Amount = amount;
            IfWin = win;
    }

        private IEnumerable<Bet> ReadBets()
        {
            List<Bet> dataCollection = new List<Bet>();
            StreamReader sr = new StreamReader(@"BetData.txt");
            using (sr)
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    dataCollection.Add(new Bet(data[0], Convert.ToDateTime(data[1]), Convert.ToDouble(data[2]), data[3]));
                }
            }
            return dataCollection;
        }

        public string MostPopularCourse()
        {
            IEnumerable<Bet> bets = ReadBets();
            var mostPopularCourse = bets
                                    .GroupBy(x => x.Course)
                                    .Where(g => g.Count() >= 1)
                                    .OrderByDescending(g => g.Count())
                                    .Select(g => g.Key)
                                    .FirstOrDefault();
            return mostPopularCourse;
        }

        public List<string> BetsDateOrder()
        {
            string win;
            IEnumerable<Bet> bets = ReadBets();
                var betsDateOrder = bets.OrderByDescending(x => x.Date)
                         .Select(x => String.Format("{0}, {1}, {2}, {3}", x.Course, string.Format("{0:MM/dd/yyyy}", x.Date), x.Amount, win = x.IfWin == "true"? "Win" : "Loss"))
                         .ToList();
                return betsDateOrder;
        }

        public string LargestWonLost()
        {

            IEnumerable<Bet> bets = ReadBets();
            var LargestWon = bets
                             .Where(w => w.IfWin == "true")
                             .OrderByDescending(x => x.Amount)
                             .Select(x => x.Amount)
                             .FirstOrDefault();

            var LargestLoss = bets
                            .Where(w => w.IfWin == "false")
                            .OrderByDescending(x => x.Amount)
                            .Select(x => x.Amount)
                            .FirstOrDefault();

            return "Largest won: " + LargestWon + "m" + "\t" + "Largest loss: " + LargestLoss + "m";

        }

        public string Success()
        {
            IEnumerable<Bet> bets = ReadBets();
            var TotalRaces = bets
                            .Count();
            var TotalWins = bets
                            .Where(g => g.IfWin == "true")
                            .Select(g => g.Course)
                            .Count();

            return "Total races: " + TotalRaces + "\t" + "Total wins: " + TotalWins;
        }

        public List<string> AmountsByYear()
        {
            IEnumerable<Bet> bets = ReadBets();

            var AmountsByYear = bets
                    .GroupBy(i => i.Date.Year)
                    .Select(g => String.Format("Year: {0} \t Total Won: {1} Total Lost: {2}", g.Key, g.Sum(i => i.IfWin == "true" ? i.Amount : 0), g.Sum(i => i.IfWin == "false" ? i.Amount : 0)
                    )).ToList();
            return AmountsByYear;
        }



    }

}
