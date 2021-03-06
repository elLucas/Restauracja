﻿using System.Windows.Controls;

namespace Restaurant.View
{
    public partial class LoginView : UserControl
    {
        private string _pinPressed = "";

        public LoginView()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_pinPressed.Length < 3)
                // zalozenie ze w przycisku jest liczba 
                _pinPressed += ((Button) sender).Content;
            else
            {
                EnableAllButtons(false);
                DTO.RestaurantServiceClient client = Misc.ServiceFactory.CreateClient();
                client.LoginCompleted += client_LoginCompleted;
                client.LoginAsync(short.Parse(_pinPressed));
            }
        }

        void client_LoginCompleted(object sender, DTO.LoginCompletedEventArgs e)
        {
            EnableAllButtons(true);
            _pinPressed = "";
            var mainView = new MainView(e.Result);
            Content = mainView;
        }

        private void EnableAllButtons(bool enable)
        {
            var panel = LayoutRoot;
            foreach (var child in panel.Children)
                if (child is Button)
                    (child as Button).IsEnabled = enable;
        }

        
    }
}
