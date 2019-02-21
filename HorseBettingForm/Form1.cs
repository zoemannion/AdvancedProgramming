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
                Submit();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }




        private void btnPopularCourse_Click(object sender, EventArgs e)
        {
            lstMostPopularCourse.Items.Clear();
            Bet b = new Bet();
            lstMostPopularCourse.Items.Add(b.MostPopularCourse());
        }

        private void btnBetsDateOrder_Click(object sender, EventArgs e)
        {
            Bet b = new Bet();         
            lstBetsByDate.DataSource = b.BetsDateOrder();
        }

        private void btnLargestWonLost_Click(object sender, EventArgs e)
        {
            lstLargestWinLoss.Items.Clear();
            Bet b = new Bet();
            lstLargestWinLoss.Items.Add(b.LargestWonLost());
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            lstSuccess.Items.Clear();
            Bet b = new Bet();
            lstSuccess.Items.Add(b.Success());
        }

        private void btnAmountsByYear_Click(object sender, EventArgs e)
        {
            Bet b = new Bet();
            lstAmountsByYear.DataSource = b.AmountsByYear();
        }

       

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, @"[^\d*\.?\d*$]"))
                {
                    MessageBox.Show("Please enter numbers");
                    txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1); 
                }
        }

        private void ClearForm()
        {
            txtRaceCourse.Clear();
            txtAmount.Clear();
        }

        private void Submit()
        {
            if(txtRaceCourse.Text.Length > 1)
            {
                txtRaceCourse.Text = txtRaceCourse.Text.Substring(0, 1).ToUpper() + txtRaceCourse.Text.Substring(1).ToLower();
            }
            else
            {
                MessageBox.Show("Please enter correct course information");
            }


            string course = txtRaceCourse.Text;
            string date = dtpDate.Text;
            string amount = txtAmount.Text;
            string winloss = cboWinorLoss.Text;

            if (course.Length == 0 || amount.Length == 0 || winloss.Length == 0)
            {
                MessageBox.Show("Please enter all information");
            }
            else if (DateTime.Parse(date) > DateTime.Now)
            {
                MessageBox.Show("Date must be in the past");
            }
            else
            {
                using (var sw = new StreamWriter(@"BetData.txt", true))  // True to append data to the file; false to overwrite the file
                {
                    if (winloss == "Win")
                    {
                        string ifwin = "true";
                        sw.WriteLine(string.Format("{0},{1},{2},{3}", new object[] { course, date, amount, ifwin }));
                    }
                    else
                    {
                        string ifwin = "false";
                        sw.WriteLine(string.Format("{0},{1},{2},{3}", new object[] { course, date, amount, ifwin }));
                    }
                }
                MessageBox.Show("Submitted");
                ClearForm();
            }
        }

    }
}


    




