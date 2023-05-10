using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Card, IMaxUse, IExpire
    {
        // Card prefix

        private List<int> prefix = new List<int>
            {
                4026,
                417500,
                4508,
                4844,
                4913,
                4917
            };

       // Implentation from interfaces
        public int maxUsed { get; set; }
        public DateTime expirydate { get; set; }

        // Constructor
        public VisaElectron(string cardHolderName, int age) : base(cardHolderName, age)
        {
            maxUsed = 10000;
            expirydate = DateTime.Now.AddYears(5);
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
                $"Monthly spending limit: {maxUsed} kr\n" +
                $"Expiry date: {expirydate.Month}-{expirydate.Year}\n";

        }
    }
}
