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
                MessageBox.Show("Submitted");
            }

        }

        private void btnPopularCourse_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"R:\Data.txt");
            string line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {

                string[] col = line.Split(',');

                var course = col[0]
                                    .OrderByDescending(gp => gp.Count())
                                    .Take(5)
                                    .Select(g => g.Key).ToList();
                this.lstBetsByDate.Items.Add(course);

            }

            sr.Close();
        }




        private void btnBetsDateOrder_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"R:\Data.txt");
            string line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                
                string[] col = line.Split(',');

                this.lstBetsByDate.Items.Add(col[0]);
                this.lstBetsByDate.Items.Add(col[1]);
                this.lstBetsByDate.Items.Add(col[2]);
                this.lstBetsByDate.Items.Add(col[3]);

            }

            sr.Close();

    
        }





    }
}



