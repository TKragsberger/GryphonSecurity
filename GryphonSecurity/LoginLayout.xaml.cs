using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace GryphonSecurity
{
    public partial class LoginLayout : PhoneApplicationPage
    {


        public LoginLayout()
        {
            InitializeComponent();

            //String lastName = textBoxLastname.Text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)textBoxBrugernavn;
            String brugernavn = t.Text;
            TextBox t2 = (TextBox)textBoxKodeord;
            String kodeord = t2.Text;

            if (brugernavn.Contains("knud") && kodeord.Contains("sutter"))
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Brugernavn eller kodeord er forkert");
            }
        }

        private void registereButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegisterLayout.xaml", UriKind.Relative));

        }
    }
}