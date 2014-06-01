using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using Windows.Devices.Geolocation;
using System.Windows.Threading;

namespace PhoneApp1
{
    class GeoLocation
    {

        double latitude;
        double longitude;

        public double getLatitude()
        {
            return latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }

        public String GetLocationCourseAndSpeed()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
           watcher.TryStart(true, TimeSpan.FromMilliseconds(1000));

            if (watcher.Position.Location.IsUnknown != true)
            {
                GeoCoordinate coord = watcher.Position.Location;
                System.Diagnostics.Debug.WriteLine("Course: {0}, Speed: {1}",
                    coord.Course,
                    coord.Speed);
                return ("Course: "+coord.Course+", Speed: "+coord.Speed);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Unknown");
                return ("Return Unknown");
            }
        }

        public String GetLocationProperty()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                System.Diagnostics.Debug.WriteLine("Lat: {0}, Long: {1}",
                    coord.Latitude,
                    coord.Longitude);
                return ("Lat: " + coord.Latitude + ", Long: " + coord.Longitude);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Unknown");
                return ("Unknown");
            }
        }


        public void Location()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                System.Diagnostics.Debug.WriteLine("Lat: {0}, Long: {1}",
                    coord.Latitude,
                    coord.Longitude);
               // return ("Lat: " + coord.Latitude + ", Long: " + coord.Longitude);
                latitude = coord.Latitude;
                longitude = coord.Longitude;

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Unknown");
                latitude = -1;
                longitude = -1;
            }
        }

        // The URI to launch
        static string uriToLaunch = "ms-settings-location:";

        // Create a Uri object from a URI string 
        Uri uri = new Uri(uriToLaunch);

        // Launch the URI
        public async void DefaultLaunch()
        {
            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);

            if (success)
            {
                // URI launched
                System.Diagnostics.Debug.WriteLine("URI Launched");
            }
            else
            {
                // URI launch failed
                System.Diagnostics.Debug.WriteLine("URI NOT Launched");
            }
        }

        
    }
}
//Created by Diana Melara