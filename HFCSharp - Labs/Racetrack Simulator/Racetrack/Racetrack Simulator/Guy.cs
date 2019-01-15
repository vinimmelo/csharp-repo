using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
        }

        public void ClearBet () { }

        public bool PlaceBet (int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            return true;
        }

        public void Collect (int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
        }
    }
}
