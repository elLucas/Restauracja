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

namespace Restaurant.View
{
    public partial class TableListView : UserControl
    {
        public TableListView()
        {
            loadAllBills();
            UserLabel.Content = getUserName();
            InitializeComponent();
        }

        /*
         * Metoda zwracająca nazwę zalogowanego użytkownika
         */
        private String getUserName()
        {
            return "Zalogowany użytkownik:";
        }

        /*
         * Metoda ładująca z bazy wszystkie aktualnie otwarte rachunki przez danego użytkownika. Rachunki będą pojawiać się w komponencie listBox
         */
        private void loadAllBills() 
        {
            throw new NotImplementedException();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "7";
                
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "9";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "6";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text += "3";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (billToOpenTextBox.Text != "")
                billToOpenTextBox.Text += "0";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            billToOpenTextBox.Text = "";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            openBill(billToOpenTextBox.Text);
        }

        /*
         * Metoda otwierająca wybrany rachunek. W pierwszej kolejności musi sprawdzać, czy taki rachunek znajduje się już w bazie. Jeśli tak to, czy jest on wolny.
         * Jeśli ktoś używa już tego rachunku, sprawdzamy jego prawa dostępu (w praktyce - manager może otwierać wszystkie rachunki, kelner tylko swoje)
         */
        private void openBill(string p)
        {
            throw new NotImplementedException();
        }
    }
}
