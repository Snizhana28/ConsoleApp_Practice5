namespace ConsoleApp_Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.Number = "1234 5678 9012 3456";
            creditCard.ExpiryDate = "12/24";
            creditCard.CardHolderName = "John Doe";
            creditCard.CVV = "123";
            creditCard.Money = 1000;
            creditCard.BillingAddress = "1234 Main St";
            creditCard.City = "New York";
            creditCard.State = "NY";
            
            Console.WriteLine("Credit Card Information");
            Console.WriteLine(creditCard.ToString());
            // operator +
            creditCard += 100;
            Console.WriteLine("Money: " + creditCard.Money);
            // operator -
            creditCard -= 100;
            Console.WriteLine("Money: " + creditCard.Money);
            // operator ==
            Console.WriteLine("CVV: " + creditCard.CVV);
            Console.WriteLine("CVV == 123: " + (creditCard == "123"));
            // operator !=
            Console.WriteLine("CVV != 123: " + (creditCard != "123"));
            // operator >
            Console.WriteLine("Money > 100: " + (creditCard > 100));
            // operator <
            Console.WriteLine("Money < 100: " + (creditCard < 100));
            // Equals()
            CreditCard creditCard2 = new CreditCard();
            creditCard2.Number = "1234 5678 9012 3456";
            creditCard2.ExpiryDate = "12/24";
            creditCard2.CardHolderName = "John Doe";
            creditCard2.CVV = "123";
            creditCard2.Money = 1000;
            creditCard2.BillingAddress = "1234 Main St";
            creditCard2.City = "New York";
            creditCard2.State = "NY";
            Console.WriteLine("Equals(): " + creditCard.Equals(creditCard2));
        }
    }
}