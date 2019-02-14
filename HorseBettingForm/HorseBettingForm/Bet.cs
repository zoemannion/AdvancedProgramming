using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseBettingForm
{
    class Bet
    {
        public string Course { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set;}
        public bool IfWin { get; set; }

    }
}
