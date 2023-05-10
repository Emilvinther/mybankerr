using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Card, IMaxDraft, IDraftDaily, IExpire, ICredit
    {
        // Card prefix
        private List<int> prefix = new List<int>
            {
                51,
                52,
                53,
                54, 
                55
            };
        // Valueables from implemented interfaces
        public int maxMonthly { get ; set; }
        public int maxDaily { get ; set; }
        public DateTime expirydate { get; set; }
        public int credit { get; set; }

        // Constructor
        public Mastercard(string cardHolderName, int age) : base(cardHolderName, age)
        {
            credit = 40000;
            expirydate = DateTime.Now.AddYears(5);
            maxDaily = 5000;
            maxMonthly = 30000;
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // String override method for output
        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Max Daily Withdraw Limit {maxDaily} kr \n" +
                $"Max Monthly Withdraw Limit {maxMonthly} kr \n" +
                $"Max Monthly Credit {credit} kr \n" +
                $"Expiry date: {expirydate.Month}-{expirydate.Year}\n";
        }
    }
}
