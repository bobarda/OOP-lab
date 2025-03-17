using System;
using System.Windows;

namespace TravelAgency
{
    public class SecurePayment : Payment
    {
        public SecurePayment(decimal amount) : base(amount) { }

        public void SecureProcess()
        {
            base.ProcessPayment();
            MessageBox.Show("Додаткова перевірка безпеки завершена.");
        }
    }
}