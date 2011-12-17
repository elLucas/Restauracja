using System.Windows;
using System.Windows.Controls;
using Restaurant.Misc;
using Restaurant.WebService;

namespace Restaurant
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RestaurantServiceClient client = ServiceFactory.CreateClient();
            client.AppNameCompleted += MainPage_AppNameCompleted;
            client.AppNameAsync();
        }

        private void MainPage_AppNameCompleted(object sender, AppNameCompletedEventArgs e)
        {
            textBlock1.Text = e.Result;
        }
    }
}