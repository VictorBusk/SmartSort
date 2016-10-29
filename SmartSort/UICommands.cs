using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SmartSort
{
    static class UICommands
    {
        private static BrushConverter bc = new BrushConverter();
        private static Brush brush;
        public static void exit()
        {
            Environment.Exit(0);
        }
        public static void minimize(Window window)
        {
            window.WindowState = WindowState.Minimized;
        }
        public static void setButtonColor(FrameworkElement sender, MainWindow window, String colorcode)
        {
            switch (((FrameworkElement)sender).Name.ToString())
            {
                case "button_home":
                    UICommands.setButtonColor(window.button_home, colorcode);
                    break;
                case "button_rules":
                    UICommands.setButtonColor(window.button_rules, colorcode);
                    break;
                case "button_settings":
                    UICommands.setButtonColor(window.button_settings, colorcode);
                    break;
            }
        }
        public static void setButtonColor(Button element, String colorCode)
        {
            brush = (Brush)bc.ConvertFrom(colorCode);
            element.Background = brush;
        }
    }
}
