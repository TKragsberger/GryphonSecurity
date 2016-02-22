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
            String customerNameTB = textBoxCustomerName.Text;
            String kundenummerTB = textBoxCustomerNumber.Text;
            String gadeOgHusnummerTB = textBoxGadeOgHusnummer.Text;
            String postnummerTB = textBoxPostnummer.Text;
            String byTB = textBoxBy.Text;
            String telefonnummerTB = textBoxTelefonnummer.Text;
            String datoTB = textBoxDato.Text;
            String tidTB = textBoxTid.Text;
            String zoneTB = textBoxZone.Text;
            Boolean indbrudHaevaerkCB = (Boolean)checkBoxIndbrudHaevaerk.IsChecked;
            Boolean vindueDorLukketCB = (Boolean)checkBoxVindueDorLukket.IsChecked;
            Boolean antruffenPersonCB = (Boolean)checkBoxAntruffenPerson.IsChecked;
            Boolean personalefejlCB = (Boolean)checkBoxPersonalefejl.IsChecked;
            Boolean intetAtBemaerkeCB = (Boolean)checkBoxIntetAtBemaerke.IsChecked;
            Boolean tekniskFejlCB = (Boolean)checkBoxTekniskFejl.IsChecked;
            Boolean ukendtAarsagCB = (Boolean)checkBoxUkendtAarsag.IsChecked;
            Boolean andetCB = (Boolean)checkBoxAndet.IsChecked;
            Boolean afmeldtUnderUdrykningCB = (Boolean)checkBoxAfmeldtUnderUdrykning.IsChecked;
            Boolean afdaekningForetagetCB = (Boolean)checkBoxAfdaekningForetaget.IsChecked;
            String bemaerkningTB = textBoxBemaerkning.Text;
            String navnTB = textBoxNavn.Text;
            String installatorTB = textBoxInstallator.Text;
            String kontrolcentralTB = textBoxKontrolcentral.Text;
            String vagtRekvireretDenTB = textBoxVagtRekvireretDen.Text;
            String vagtRekvireretFraTB = textBoxVagtRekviveretFra.Text;
            String vagtRekvireretTilTB = textBoxVagtRekviveretTil.Text;
            String varFremmeTB = textBoxVarFremme.Text;
            String faedigTB = textBoxFaedig.Text;
            
        }
    }
}