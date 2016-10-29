using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

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
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("My ApplicationStartUpDemo", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"");
            }
        }

        private void startUnchecked(object sender, RoutedEventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("My ApplicationStartUpDemo", false);
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void applyBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Danish":
                    //Danish.setDanish();
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("da-DK");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da-DK");
                    break;
                case "English":
                    //English.setEnglish();
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    break;
                case "German":
                    //German.setGerman();
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("da-DK");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da-DK");
                    break;
            }

        }
    }
}
