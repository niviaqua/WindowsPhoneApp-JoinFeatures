using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1
{
    class PassParameters
    {

        String phoneNumber = null;
        DateTime initialDate;
        double initialLongitude;
        double initialLatitude;


        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void setInitialDate(DateTime initialDate)
        {
            this.initialDate = initialDate;
        }

        public void setInitialLongitude(double initialLongitude)
        {
            this.initialLongitude = initialLongitude;
        }

        public void setInitialLatitude(double initialLatitude)
        {
            this.initialLatitude = initialLatitude;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public DateTime getInitialDate()
        {
            return initialDate;
        }

        public double getInitialLatitude()
        {
            return initialLatitude;
        }

        public double getInitialLongitude()
        {
            return initialLongitude;
        }

    }
}

//Created by Diana Melara
