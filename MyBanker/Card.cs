

namespace MyBanker
{
    public abstract class Card
    {
        // Bank prefix
        protected const int BankPrefix = 3520;

        // Card information
        protected string cardHolderName;
        protected int age;
        protected string cardnumber;
        protected string accountNumber;
        protected int cardPrefix;

        private Random random = new Random();

        private string cardNumberString = "";

        private string accountNumberString = "";


        //Constructor
        public Card(string cardHolderName, int age)
        {
            this.cardHolderName = cardHolderName;
            this.age = age;
        }

        // Method generating a card number and making them into a string
        protected virtual string GetCardNumber()
        {
            cardNumberString += $"{cardPrefix}-";

            for (int i = 0; i < 16 - cardPrefix.ToString().Length; i++)
            {
                cardNumberString += random.Next(0, 10);
            }

            return cardNumberString;
        }
        // Method generating an account number and making them into a string
        protected virtual string GetAccountNumber()
        {
            accountNumberString += $"{BankPrefix}-";

            for (int i = 0; i < 10; i++)
            {
                accountNumberString += random.Next(0, 10);
            }

            return accountNumberString;
        }

        // Picking a random card prefix
        protected virtual int GetCardPrefix(List<int> prefix)
        {
            return prefix[random.Next(0, prefix.Count)];
        }
    }
}
