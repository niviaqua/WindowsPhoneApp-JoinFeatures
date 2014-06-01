using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace PhoneApp1
{
    public static class Extensions
    {
        private static object Data;

        public static void Navigate(this NavigationService navigationService,
                                    Uri source, object data)
        {
            Data = data;
            navigationService.Navigate(source);
        }

        public static object GetNavigationData(this NavigationService service)
        {
            return Data;
        }
    }
}
