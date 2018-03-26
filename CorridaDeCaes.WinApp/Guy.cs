using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaDeCaes.WinApp
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string name, int cash, RadioButton radioBtn, Label mylbl)
        {
            MyBet = new Bet(this);
            this.Name = name;
            this.Cash = cash;
            this.MyRadioButton = radioBtn;
            this.MyLabel = mylbl;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            this.MyRadioButton.Text = Name + " tem " + this.Cash + " Reais";
            this.MyLabel.Text = MyBet.GetDescription();
        }
        public void ClearBet()
        {
            MyBet = new Bet(this);
        }
        public bool PlaceBet(int amount, int dog)
        {
            if (amount <= Cash)
            {
                MyBet.Amount = amount;
                MyBet.Dog = dog;
                UpdateLabels();
                return true;
            }

            return false;
        }
        public void Collect(int winner)
        {
            this.Cash += MyBet.PayOut(winner); 
            UpdateLabels();
            ClearBet();
        }

    }
}
