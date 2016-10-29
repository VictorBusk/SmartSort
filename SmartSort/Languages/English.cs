using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SmartSort
{
    static class English
    {
        public static void setEnglish()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button_home.Content = "Home";
                    (window as MainWindow).button_rules.Content = "Rules";
                    (window as MainWindow).button_settings.Content = "Settings";
                }
            }
        }
    }
}
