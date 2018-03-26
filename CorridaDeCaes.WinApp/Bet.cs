using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCaes.WinApp
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(Guy guy)
        {
            this.Amount = 0;
            this.Dog = 0;
            this.Bettor = guy;
        }

        public string GetDescription()
        {
            if (Amount == 0)
                return Bettor.Name + " ainda não apostou";

            return Bettor.Name + " apostou " + Amount + " Reais no cão numero " + Dog ;
        }
        public int PayOut(int winner)
        {
            if (Dog == winner)
                return this.Amount;
                       
            return Amount * (-1);
        }
    }
}
