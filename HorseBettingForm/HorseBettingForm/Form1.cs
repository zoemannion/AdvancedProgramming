using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace HorseBettingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }


    private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Submitted");
            }

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
        private void btnPopularCourse_Click(object sender, EventArgs e)
        {
            lstMostPopularCourse.Items.Clear();
            IEnumerable<Bet> bets = ReadBets();
            var mostPopularCourse = bets
                                    .GroupBy(x => x.Course)
                                    .Where(g => g.Count() >= 1)
                                    .OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();

            lstMostPopularCourse.Items.Add(mostPopularCourse);
        }

        private void btnBetsDateOrder_Click(object sender, EventArgs e)
        {
            lstBetsByDate.Items.Clear();
            IEnumerable<Bet> bets = ReadBets();
            //var betsDateOrder = bets
            //                    .OrderByDescending(x => x.Date)
            //                    .ToList();

            var betsDateOrder = bets.OrderByDescending(x => x.Date)
                     .Select(x => String.Format("{0}, {1}, {2}, {3}", x.Course, x.Date, x.Amount, x.IfWin))
                     .ToList();

            //lstBetsByDate.DataSource = DateOrder;
            //lstBetsByDate.DataValueField = "Value";
            //lstBetsByDate.DataTextField = "Text";

            lstBetsByDate.DataSource = betsDateOrder;
        }

        private void btnLargestWonLost_Click(object sender, EventArgs e)
        {
            lstLargestWinLoss.Items.Clear();
            IEnumerable<Bet> bets = ReadBets();
                    var LargestWon = bets
                                     .Where(g => g.IfWin == "true")
                                     .OrderByDescending(x => x.Amount)
                                     .Select(c => c.Course)
                                     .FirstOrDefault();

                    var LargestLoss = bets
                                    .Where(w => w.IfWin == "false")
                                    .OrderByDescending(x => x.Amount)
                                    .Select(c => c.Course)
                                    .FirstOrDefault();

                    lstLargestWinLoss.Items.Add("Largest win: " + LargestWon);
                    lstLargestWinLoss.Items.Add("Largest loss: " + LargestLoss);
         }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            lstSuccess.Items.Clear();
            IEnumerable<Bet> bets = ReadBets();
            var TotalRaces = bets
                            .Count();


            var TotalWins = bets
                            .Where(g => g.IfWin == "true")
                            .Select(g => g.Course)
                            .Count();

            lstSuccess.Items.Add("Total no. races: " + TotalRaces);
            lstSuccess.Items.Add("Total no. wins: " + TotalWins);
        }
    }


    }




