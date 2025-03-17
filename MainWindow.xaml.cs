using System;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace TravelAgency
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookTravelButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            if (!int.TryParse(ageTextBox.Text, out int age))
            {
                MessageBox.Show("Будь ласка, введіть коректний вік.", "Помилка");
                return;
            }

           

            string destination = ((ComboBoxItem)destinationComboBox.SelectedItem).Content.ToString();
            string travelPackage = ((ComboBoxItem)travelPackageComboBox.SelectedItem).Content.ToString();
            string paymentMethod = ((ComboBoxItem)paymentMethodComboBox.SelectedItem).Content.ToString();

            Tourist tourist = new Tourist(name, age);
            TravelPackage travelPackageObject = new TravelPackage(destination, travelPackage);

            Payment payment;

            switch (paymentMethod)
            {
                case "Online Payment":
                    payment = new OnlinePayment(travelPackageObject.Price);
                    break;
                case "Secure Payment":
                    payment = new SecurePayment(travelPackageObject.Price);
                    break;
                case "Credit Card Payment":
                    payment = new CreditCardPayment(travelPackageObject.Price);
                    break;
                default:
                    MessageBox.Show("Будь ласка, виберіть метод оплати.", "Помилка");
                    return;
            }

            MessageBoxResult result = MessageBox.Show($"Оплатити {travelPackageObject.Price} $?", "Підтвердження", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                payment.ProcessPayment();
                resultTextBlock.Text = $"Booking successful! {tourist.Name} has booked a {travelPackageObject.Destination} trip with {travelPackageObject.TravelPackageType} package.";
            }
            else
            {
                MessageBox.Show("Оплату скасовано.");
                resultTextBlock.Text = "Booking cancelled.";
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = "Booking cancelled.";
        }
    }
}