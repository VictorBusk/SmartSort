using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace SmartSort
{
    /// <summary>
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : UserControl
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {
            BitmapImage starGlow = new BitmapImage();
            starGlow.UriSource = new Uri(@"C:\Users\Mikkel\Documents\GitHub\SmartSort\SmartSort\Image\stars_yellow.png");
            switch (((FrameworkElement)sender).Name.ToString())
            {
                case "image_start1":
                    image_start1.Source = starGlow;
                    break;
            }
        }


        private void image_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void startChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Assembly curAssembly = Assembly.GetExecutingAssembly();
                key.SetValue(curAssembly.GetName().Name, curAssembly.Location);
            }
            catch { }
        }

        private void startUnchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Assembly curAssembly = Assembly.GetExecutingAssembly();
                key.DeleteValue(curAssembly.GetName().Name, false);
            }
            catch { }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void applyBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Danish":
                    Danish.setDanish();
                    break;
                case "English":
                    English.setEnglish();
                    break;
                case "German":
                    German.setGerman();
                    break;
            }

        }
    }
}
