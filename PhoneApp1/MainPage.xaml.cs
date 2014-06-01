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
    public partial class MainPage : PhoneApplicationPage
    {

        public String phoneNumber;
        public PhoneNumberChooserTask phoneNumberChooserTask;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            phoneNumberChooserTask = new PhoneNumberChooserTask();
            phoneNumberChooserTask.Completed += new EventHandler<PhoneNumberResult>(phoneNumberChooserTask_Completed);

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeoLocation Gl = new GeoLocation();
            MessageBoxResult result = MessageBox.Show(Gl.GetLocationCourseAndSpeed(),
            "Response", MessageBoxButton.OK);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GeoLocation Gl = new GeoLocation();

            MessageBoxResult result = MessageBox.Show(Gl.GetLocationProperty(),
            "Response", MessageBoxButton.OK);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GeoLocation Gl = new GeoLocation();
            Gl.DefaultLaunch();
        }


        private void GetStartedButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pg2_Contacts.xaml", UriKind.Relative));
        }

    }
}
//Created by Diana Melara