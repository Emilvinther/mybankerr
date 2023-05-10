

namespace MyBanker
{
    public class DebitCard : Card
    {
        // Card prefix
        private List<int> prefix = new List<int>
            {
                2400,
            };

        // Constructor
        public DebitCard(string cardHolderName, int age) : base(cardHolderName, age)
        {

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
                $"Card number: {cardnumber}\n";
        }
    }
}
