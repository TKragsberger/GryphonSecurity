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
    public partial class AlarmRapport : PhoneApplicationPage
    {
        public AlarmRapport()
        {
            InitializeComponent();
        }

        private void sendRapport_Click(object sender, RoutedEventArgs e)
        {
            TextBox kundenavnTB= (TextBox)textBoxKundenavn;
            String kundenavn = kundenavnTB.Text;
            TextBox kundenummerTB = (TextBox)textBoxKundenummer;
            String kundenummer = kundenavnTB.Text;
            TextBox gadeOgHusnummerTB = (TextBox)textBoxGadeOgHusnummer;
            String gadeOgHusnummer = gadeOgHusnummerTB.Text;
            TextBox postnummerTB = (TextBox)textBoxPostnummer;
            String postnummer = postnummerTB.Text;
            TextBox byTB = (TextBox)textBoxBy;
            String by = byTB.Text;
            TextBox telefonnummerTB = (TextBox)textBoxTelefonnummer;
            String telefonnummer = telefonnummerTB.Text;
            TextBox datoTB = (TextBox)textBoxDato;
            String dato = datoTB.Text;
            TextBox tidTB = (TextBox)textBoxTid;
            String tid = tidTB.Text;
            TextBox zoneTB = (TextBox)textBoxZone;
            String zone = zoneTB.Text;
        }
    }
}