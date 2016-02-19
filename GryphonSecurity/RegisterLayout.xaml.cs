using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Diagnostics;

namespace GryphonSecurity
{
    public partial class RegisterLayout : PhoneApplicationPage
    {
        Controller controller = Controller.Instance;
        public RegisterLayout()
        {
            InitializeComponent();
        }

        private void RegistrerBrugerButton_Click(object sender, RoutedEventArgs e)
        {
            String firstname = textBoxFirstname.Text;
            String lastname = textBoxLastName.Text;
            String address = textBoxAddress.Text;
            long phonenumber = Convert.ToInt64(textBoxPhonenumber.Text);
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            String passwordConfirm = textBoxPasswordConfirm.Text;
            if (password.Equals(passwordConfirm))
            {
                try
                {
                    User user = new User(firstname, lastname, address, phonenumber);
                    Debug.WriteLine("test");
                    if (controller.createUser(user))
                    {
                        MessageBox.Show("Bruger oprettet");
                        NavigationService.Navigate(new Uri("/LoginLayout.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Bruger blev ikke oprettet");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Fejl i registrering");
                }
            }
            else
            {
                MessageBox.Show("kodeord var ikke ens");
            }
        }
    }
}