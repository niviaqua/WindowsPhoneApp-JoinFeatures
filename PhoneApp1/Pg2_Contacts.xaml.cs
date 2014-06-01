using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using Microsoft.Phone.UserData;
using Microsoft.Phone.Tasks;


namespace PhoneApp1
{
    public partial class Page2 : PhoneApplicationPage
    {
        public String phoneNumber;
        public PhoneNumberChooserTask phoneNumberChooserTask;

        public Page2()
        {
            InitializeComponent();

            phoneNumberChooserTask = new PhoneNumberChooserTask();
            phoneNumberChooserTask.Completed += new EventHandler<PhoneNumberResult>(phoneNumberChooserTask_Completed);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            phoneNumberChooserTask.Show();
        }

        void phoneNumberChooserTask_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show("The phone number chosen is " + e.DisplayName + " with " + e.PhoneNumber);
                phoneNumber = e.PhoneNumber;

                //Code to start a new call using the retrieved phone number.
                //PhoneCallTask phoneCallTask = new PhoneCallTask();
                //phoneCallTask.DisplayName = e.DisplayName;
                //phoneCallTask.PhoneNumber = e.PhoneNumber;
                //phoneCallTask.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PassParameters ps = new PassParameters();

            DateTime startTime = DateTime.UtcNow;
            ps.setInitialDate(startTime);

            GeoLocation GL = new GeoLocation();
            GL.Location();
            ps.setPhoneNumber(phoneNumber);
            ps.setInitialLatitude( GL.getLatitude() );
            ps.setInitialLongitude( GL.getLongitude() );

            NavigationService.Navigate(new Uri("/Pg3_Reached.xaml", UriKind.Relative), ps);
        }
    }
}

//Created by Diana Melara