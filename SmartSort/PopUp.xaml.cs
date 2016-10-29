using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SmartSort
{
    /// <summary>
    /// Interaction logic for PopUp.xaml
    /// </summary>
    public partial class PopUp : Window
    {
        private bool contentAgreed = false;
        private bool closed = false;
        public PopUp(String title, String message, String agreeButton, String cancelButton)
        {
            InitializeComponent();
            init(title, message, agreeButton, cancelButton);
        }
        public PopUp(Window window, String title, String message)
        {
            InitializeComponent();
            init(title, message, "Agree", "Cancel");
        }
        private void init(String title, String message, String agreeButton, String cancelButton)
        {
            label_popup_title.Content = title;
            textBlock_popup_message.Text = message;
            button_popup_agree.Content = agreeButton;
            button_popup_cancel.Content = cancelButton;
            this.Show();
        }
        public bool ContentAgreed()
        {
            return contentAgreed;
        }
        public bool isclosed()
        {
            return closed;
        }
        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

        private void button(object sender, RoutedEventArgs e)
        {
            if (((FrameworkElement)sender).Name.ToString().Equals(button_popup_agree.Content))
            {
                contentAgreed = true;
            }
            closed = true;
            this.Close();
        }
    }
}
