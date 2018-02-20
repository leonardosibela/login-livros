﻿using System.Windows;

namespace loginlivros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUser.Text;
            string password = pwbPassword.Password.ToString();

            if (userName.Equals("pfalves") && password.Equals("etec123"))
            {
                
            }
            else
            {
                displayInvalidUserMessage();
            }
        }

        private void displayInvalidUserMessage()
        {
            MessageBox.Show("Favor verificar se você não digitou nada errado",
                "Usuário ou senha inválidos",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
