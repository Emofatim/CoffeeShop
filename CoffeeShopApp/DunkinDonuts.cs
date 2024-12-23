using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    public class DunkinDonuts : CoffeeShop
    {
        public DunkinDonuts(string name, double initialBalance) : base(name, initialBalance) { }

        public override void MakeOrder(double amount, string orderDetails)
        {
            if (IsFrozen)
                throw new InvalidOperationException("Account is frozen. Cannot make an order.");

            if (amount <= 0)
                throw new ArgumentException("Order amount must be greater than zero.");

            if (amount > Balance)
                throw new InvalidOperationException("Price exceeds balance.");

            Balance -= amount;
            Console.WriteLine($"Order placed at Dunkin Donuts: {orderDetails} for {amount}. Remaining balance: {Balance}");
        }

        public override void CancelOrder(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Order cancelled at Dunkin Donuts. Refunded {amount}. New balance: {Balance}");
        }
    }
}
