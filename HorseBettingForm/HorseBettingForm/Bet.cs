using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace HorseBettingForm
{
    class Bet
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
            using (var f = new StreamReader(@"R:\Data.txt"))
            {
                string line = string.Empty;
                while ((line = f.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    dataCollection.Add(new Bet(data[0], Convert.ToDateTime(data[1]), Convert.ToDouble(data[2]), data[3]));
                }
            }
            return dataCollection;
        }



        public string MostPopularCourse(IEnumerable<Bet> bets)
        {
            bets = ReadBets();
            var mostPopularCourse = bets
                                    .GroupBy(x => x.Course)
                                    .Where(g => g.Count() >= 1)
                                    .OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            return mostPopularCourse;
        }


    }

}
