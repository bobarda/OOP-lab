using System;
using System.Windows;

namespace TravelAgency
{
    public sealed class FinalPayment : Payment
    {
        public FinalPayment(decimal amount) : base(amount) { }

        public sealed override void ProcessPayment()
        {
            MessageBox.Show("Фінальна оплата проведена без можливості відміни.");
        }
    }
}