using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;


namespace csxto.ViewModel
{
    class SingleTrack
    {
        internal static string SingleOverviewBuilder(string stateCode)
        {
            const string baseString = "State: ";
            string returnState = null;
            switch (stateCode)
            {
                case "0":
                    returnState = "Shipping";
                    break;
                case "1":
                    returnState = "Company received";
                    break;
                case "2":
                    returnState = "Difficult";
                    break;
                case "3":
                    returnState = "Received";
                    break;
                case "4":
                    returnState = "Returned";
                    break;
                case "5":
                    returnState = "Delivering";
                    break;
                case "6":
                    returnState = "Returning";
                    break;
            }
            return baseString + returnState;
        }

        internal static MainWindow.Json DeserializeJson(string rawJson)
        {
            var json = JsonConvert.DeserializeObject<MainWindow.Json>(rawJson);
            return json;
        }

    }
}
