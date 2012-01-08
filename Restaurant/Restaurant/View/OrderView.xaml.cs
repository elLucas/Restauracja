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
using System.Windows.Navigation;

namespace Restaurant.View
{
    public partial class CheckView : Page
    {
        List<String> orders = new List<String>();
        List<String> products = new List<String>();
        bool zmianaStolika = false;
        


        public CheckView()
        {
            InitializeComponent();

            
            orders.Add("Ilosc Nazwa Wartosc");
            orders.Add("12    Mewy  12$");

            products.Add("1\tabb");
            products.Add("12\tCljaaaa");

            this.listBox1.ItemsSource = orders;
            this.listBox2.ItemsSource = products;
        }

        private void zmien_Click(Object sender, System.Windows.RoutedEventArgs e)
        {
            

            if (!zmianaStolika)
            {
                ((TextBox)(((Button)sender).FindName("textBoxZmienStolik"))).Text = 
                    (String)((Label)(((Button)sender).FindName("labelStol"))).Content;
                ((TextBox)(((Button)sender).FindName("textBoxZmienStolik"))).Visibility = Visibility.Visible;
            }
            else
            {
                ((TextBox)(((Button)sender).FindName("textBoxZmienStolik"))).Visibility = Visibility.Collapsed;

                int a = Convert.ToInt32(((TextBox)(((Button)sender).FindName("textBoxZmienStolik"))).Text);
                ((Label)(((Button)sender).FindName("labelStol"))).Content = Convert.ToString(a);
            }
            zmianaStolika = !zmianaStolika;
        }

        private void dodaj_Click(Object sender, System.Windows.RoutedEventArgs e)
        {

        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
