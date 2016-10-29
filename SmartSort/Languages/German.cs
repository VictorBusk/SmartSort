using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SmartSort
{
    static class German
    {
        public static void setGerman()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button_home.Content = "Heim";
                    (window as MainWindow).button_rules.Content = "Regeln";
                    (window as MainWindow).button_settings.Content = "Einstellungen";
                }
            }
        }
    }
}
