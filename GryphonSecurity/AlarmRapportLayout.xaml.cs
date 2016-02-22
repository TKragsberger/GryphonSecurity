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

        private void sendReport_Click(object sender, RoutedEventArgs e)
        {
            String customerNameTB = textBoxCustomerName.Text;
            String customerNumberTB = textBoxCustomerNumber.Text;
            String streetAndHouseNumberTB = textBoxStreetAndHouseNumber.Text;
            String zipCodeTB = textBoxZipCode.Text;
            String cityTB = textBoxCity.Text;
            String phonenumberTB = textBoxPhonenumber.Text;
            String dateTB = textBoxDate.Text;
            String timeTB = textBoxTime.Text;
            String zoneTB = textBoxZone.Text;
            Boolean burglaryVandalismkCB = (Boolean)checkBoxBurglaryVandalism.IsChecked;
            Boolean windowDoorClosedCB = (Boolean)checkBoxWindowDoorClosed.IsChecked;
            Boolean apprehendedPersonCB = (Boolean)checkBoxApprehendedPerson.IsChecked;
            Boolean staffErrorCB = (Boolean)checkBoxStaffError.IsChecked;
            Boolean nothingToReportCB = (Boolean)checkBoxNothingToReport.IsChecked;
            Boolean technicalErrorCB = (Boolean)checkBoxTechnicalError.IsChecked;
            Boolean unknownReasonCB = (Boolean)checkBoxUnknownReason.IsChecked;
            Boolean otherCB = (Boolean)checkBoxOther.IsChecked;
            Boolean cancelsDuringEmergencyCB = (Boolean)checkBoxCancelsDuringEmergency.IsChecked;
            Boolean coverMadeCB = (Boolean)checkBoxCoverMade.IsChecked;
            String remarkTB = textBoxRemark.Text;
            String nameTB = textBoxName.Text;
            String installerTB = textBoxInstaller.Text;
            String controlCenterTB = textBoxControlCenter.Text;
            String guardRadioedDateTB = textBoxGuardRadioedDate.Text;
            String guardRadioedFromTB = textBoxGuardRadioedFrom.Text;
            String guardRadioedToTB = textBoxGuardRadioedTo.Text;
            String arrivedAtTB = textBoxArrivedAt.Text;
            String doneTB = textBoxDone.Text;
            
        }
    }
}