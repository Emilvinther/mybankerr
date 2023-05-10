using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : Card, IMaxDraft, IMaxUse, IExpire
    {
        // Card prefix
        private List<int> prefix = new List<int>
            {
                4
            };

        // Valueables from implemented interfaces
        public int maxUsed { get; set; }
        public int maxMonthly { get; set; }
        public DateTime expirydate { get; set; }

        // Constructor
        public Visa(string cardHolderName, int age) : base(cardHolderName, age)
        {
            maxUsed = 20000;
            maxMonthly = 25000;
            expirydate = DateTime.Now.AddYears(5);
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // String override for output
        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Monthly spending limit: {maxUsed} kr\n" +
                $"Max Monthly Withdraw Limit {maxMonthly} kr\n" +
                $"Expiry date: {expirydate.Month}-{expirydate.Year}\n";

        }

    }
}
