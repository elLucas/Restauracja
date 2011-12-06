using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Restauracja.RestaurantService;
using System.Windows.Browser;
using Restauracja.Misc;

namespace Restauracja
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
            client.GetAppNameCompleted += new EventHandler<GetAppNameCompletedEventArgs>(client_GetAppNameCompleted);
            client.GetAppNameAsync();
        }

        void client_GetAppNameCompleted(object sender, GetAppNameCompletedEventArgs e)
        {
            this.label1.Content = e.Result;
        }
    }
}
