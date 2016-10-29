using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartSort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            InitializeComponent();
            this.Page.Children.RemoveRange(0, this.Page.Children.Count);
            this.Page.Children.Add(new HomeWindow());
    }
        public void mouseclick(Object sender)
        {
            PopUp pop = new PopUp("Test", "This is the content", "Yes", "No");
            switch (((FrameworkElement)sender).Name.ToString())
            {
                case "image_minimize":
                    UICommands.minimize(this);
                    break;
                case "image_exit":
                    UICommands.exit();
                    break;
                case "button_home":
                    this.Page.Children.RemoveRange(0, this.Page.Children.Count);
                    this.Page.Children.Add(new HomeWindow());
                    break;
                case "button_rules":
                    this.Page.Children.RemoveRange(0, this.Page.Children.Count);
                    this.Page.Children.Add(new RuleWindow());
                    break;
                case "button_settings":
                    this.Page.Children.RemoveRange(0, this.Page.Children.Count);
                    this.Page.Children.Add(new SettingWindow());
                    break;
            }
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            UICommands.setButtonColor((FrameworkElement)sender, this, "#3f5266");
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            UICommands.setButtonColor((FrameworkElement)sender, this, "#2e4053");
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                try
                {
                    this.DragMove();
                }
                catch (Exception) { }
        }

        private void mouse_Click(object sender, RoutedEventArgs e)
        {
            mouseclick(sender);
        }
        private void mouse_Click(object sender, MouseButtonEventArgs e)
        {
            mouseclick(sender);
        }
    }
}
