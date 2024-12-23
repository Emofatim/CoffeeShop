using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    public abstract class CoffeeShop
    {
        // Encapsulated fields
        private string _name;
        private double _balance;
        private bool _isFrozen = false;

        // Public properties with encapsulation
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty.");
            }
        }

        public double Balance
        {
            get { return _balance; }
            protected set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new ArgumentException("Balance cannot be negative.");
            }
        }

        public bool IsFrozen
        {
            get { return _isFrozen; }
            protected set { _isFrozen = value; }
        }

        // Constructor
        public CoffeeShop(string name, double initialBalance)
        {
            Name = name;
            Balance = initialBalance;
        }

        // Abstract methods to be implemented by derived classes
        public abstract void MakeOrder(double amount, string orderDetails);

        public abstract void CancelOrder(double amount);

        // Common functionality
        public void FreezeAccount()
        {
            IsFrozen = true;
            Console.WriteLine($"{Name} account is frozen.");
        }

        public void UnfreezeAccount()
        {
            IsFrozen = false;
            Console.WriteLine($"{Name} account is unfrozen.");
        }
    }

}
