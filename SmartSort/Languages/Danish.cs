using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SmartSort
{
    static class Danish
    {
        public static void setDanish()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).button_home.Content = "Hjem";
                    (window as MainWindow).button_rules.Content = "Regler";
                    (window as MainWindow).button_settings.Content = "Indstillinger";
                }
            }
            //foreach (Window window in Application.Current.Windows)
            //{
            //    if (window.GetType() == typeof(MainWindow))
            //    {
            //        (window as MainWindow).rulesLabel.Content = "Regler";
            //        window.RuleWindow.rulesLabel.Content
            //        (window as RuleWindow).TitLabel.Content = "Titel";
            //        (window as RuleWindow).sourcesLabel.Content = "Kilder";
            //        (window as RuleWindow).destLabel.Content = "Destination";
            //    }
            //}
            
        }
    }
}
