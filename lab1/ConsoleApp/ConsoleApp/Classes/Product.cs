

using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    
    public class Product : IProduct
    {
        public string Name { get; set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void PriceDecrease(int cash, int cents)
        {
            int totalCents = Price.Cash * 100 + Price.Cents - (cash * 100 + cents);
            if (totalCents < 0) totalCents = 0;
            Price.SetCash(totalCents / 100, totalCents % 100);
        }
    }
    
};

