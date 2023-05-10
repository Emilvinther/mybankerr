using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Card, IExpire
    {
        private Random random = new Random();

        private string cardNumberString = "";

        private string accountNumberString = "";

        // Card prefix
        private List<int> prefix = new List<int>
            {
                5018, 
                5020,
                5038, 
                5893, 
                6304,
                6759, 
                6761,
                6762, 
                6763
            };

        // Implentation from interface
        public DateTime expirydate {get; set;}

        // Constructor
        public Maestro(string cardHolderName, int age) : base(cardHolderName, age)
        {
            expirydate = DateTime.Now.AddYears(5).AddMonths(8);
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // Overide GetCardNumber method
        // Because the amount of numbers is different
        // than the other cards
        protected override string GetCardNumber()
        {
            cardNumberString += $"{cardPrefix}-";

            for (int i = 0; i < 19 - cardPrefix.ToString().Length; i++)
            {
                cardNumberString += random.Next(0, 10);
            }

            return cardNumberString;
        }

        // String override method for output

        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Expiry date: {expirydate.Month}-{expirydate.Year}\n";
        }
    }
}
