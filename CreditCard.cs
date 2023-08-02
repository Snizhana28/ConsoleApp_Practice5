using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice5
{
    public class CreditCard
    {
        public string Number { get; set; }
        public string ExpiryDate { get; set; }
        public string CardHolderName { get; set; }
        public string CVV { get; set; }
        public double Money { get; set; }
        public string BillingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public CreditCard() { }
        public CreditCard(string number, string expiryDate, string cardHolderName, string cvv, double money, string billingAddress, string city, string state)
        {
            Number = number;
            ExpiryDate = expiryDate;
            CardHolderName = cardHolderName;
            CVV = cvv;
            Money = money;
            BillingAddress = billingAddress;
            City = city;
            State = state;
        }
        public static CreditCard operator +(CreditCard card, double money)
        {
            card.Money += money;
            return card;
        }
        public static CreditCard operator -(CreditCard card, double money)
        {
            card.Money -= money;
            return card;
        }
        public static bool operator ==(CreditCard card, string cvv)
        {
            return card.CVV == cvv;
        }
        public static bool operator !=(CreditCard card, string cvv)
        {
            return card.CVV != cvv;
        }
        public static bool operator >(CreditCard card, double money)
        {
            return card.Money > money;
        }
        public static bool operator <(CreditCard card, double money)
        {
            return card.Money < money;
        }
        public override bool Equals(object obj)
        {
            return obj is CreditCard card &&
                   Number == card.Number &&
                   ExpiryDate == card.ExpiryDate &&
                   CardHolderName == card.CardHolderName &&
                   CVV == card.CVV &&
                   BillingAddress == card.BillingAddress &&
                   City == card.City &&
                   State == card.State &&
                   Money == card.Money;
        }
        public override string ToString()
        {
            return $"Number: {Number}" +
                $"\nExpiryDate: {ExpiryDate}" +
                $"\nCardHolderName: {CardHolderName}" +
                $"\nCVV: {CVV}" +
                $"\nMoney: {Money}" +
                $"\nBillingAddress: {BillingAddress}" +
                $"\nCity: {City}" +
                $"\nState: {State}";
        }
    }
}
