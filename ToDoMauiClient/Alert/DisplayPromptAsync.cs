using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMauiClient.Alert
{
    public partial class DisplayPromptAsync : ContentPage
    {
        public  DisplayPromptAsync()
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}
