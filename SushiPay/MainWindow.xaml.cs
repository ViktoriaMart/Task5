using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.IO;
using System.Collections;
using System.Windows.Media;
using System.Threading.Tasks;
using BUS;
using Models;

namespace SushiPay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Requst> collection;
        System.Windows.Threading.DispatcherTimer timer;

        OrderBUS orderBUS;
        public double Sum
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();
            orderBUS = new OrderBUS();

            timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 2);
        }

        public void timerTick(object sender, EventArgs e)
        {
            Messages.Text = String.Empty;
            MessagesLabel.Background = new SolidColorBrush(Colors.Lavender);
            timer.Stop();
        }

        private void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                collection = orderBUS.GetOrder();
                Sum = orderBUS.GetSum(collection);

                prodList.ItemsSource = collection;
                LeastSum.Text = "Загальна сума: " + Sum;
            }
            catch (Exception exeption)
            {
                MessagesLabel.Background = new SolidColorBrush(Color.FromRgb(51, 255, 51));
                Messages.Text = exeption.Message;
            }

        }

        private void buttonCreditPay_Click(object sender, RoutedEventArgs e)
        {
            Window1 CardPayWindow = new Window1();
            CardPayWindow.ForSum.Content = "Сума до оплати: " + Sum;

            if (CardPayWindow.ShowDialog() == true)
            {
                orderBUS.RemoveAll(collection);
                LeastSum.Text = "Загальна сума: ";
                MessagesLabel.Background = new SolidColorBrush(Color.FromRgb(51, 255, 51));
                Messages.Text = "Оплату проведено!";
                Sum = 0;
                orderBUS.DeleteOrder();
            }
            else
            {
                MessagesLabel.Background = new SolidColorBrush(Color.FromRgb(255, 26, 26));
                Messages.Text = "Операція відмінена!";
            }
            timer.Start();
        }

        private void buttonCashPay_Click(object sender, RoutedEventArgs e)
        {
            Window2 CashPayWindow = new Window2();
            CashPayWindow.ForSum.Content = "Сума до оплати: " + Sum;
            CashPayWindow.Sum = Sum;

            if (CashPayWindow.ShowDialog() == true)
            {
                orderBUS.RemoveAll(collection);
                LeastSum.Text = "Загальна сума: ";
                MessagesLabel.Background = new SolidColorBrush(Color.FromRgb(51, 255, 51));
                Messages.Text = "Оплату проведено!";
                Sum = 0;
                orderBUS.DeleteOrder();
            }
            else
            {
                MessagesLabel.Background = new SolidColorBrush(Color.FromRgb(255, 26, 26));
                Messages.Text = "Операція відмінена!";
            }
            timer.Start();
        }
    }
}
