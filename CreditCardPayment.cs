using System.Windows;

namespace TravelAgency
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(decimal amount) : base(amount) { }

        public override void ProcessPayment()
        {
            MessageBox.Show("Оплата через Credit Card завершена.");
        }
    }
}