using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create coffee shop accounts
                CoffeeShop starbucks = new Starbucks("Starbucks", 100);
                CoffeeShop dunkinDonuts = new DunkinDonuts("Dunkin Donuts", 50);

                // Place orders
                starbucks.MakeOrder(30, "Latte");
                dunkinDonuts.MakeOrder(20, "Donut and Coffee");

                // Cancel an order
                starbucks.CancelOrder(10);

                // Freeze and unfreeze accounts
                dunkinDonuts.FreezeAccount();
                dunkinDonuts.UnfreezeAccount();

                // Attempting to place an order on a frozen account
                dunkinDonuts.FreezeAccount();
                dunkinDonuts.MakeOrder(10, "Iced Coffee"); // This will throw an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
