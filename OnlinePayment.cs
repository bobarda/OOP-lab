using System.Windows;

namespace TravelAgency
{
    public class OnlinePayment : Payment
    {
        public OnlinePayment(decimal amount) : base(amount) { }

        public override void ProcessPayment()
        {
            MessageBox.Show($"Online payment of {Amount} $ completed.");
        }
    }
}