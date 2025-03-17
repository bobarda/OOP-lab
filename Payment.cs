using System.Windows;

namespace TravelAgency
{
    public abstract class Payment
    {
        public decimal Amount { get; set; }

        public Payment(decimal amount)
        {
            Amount = amount;
        }

        public virtual void ProcessPayment()
        {
            MessageBox.Show($"Processing payment of {Amount} $.");
        }
    }
}