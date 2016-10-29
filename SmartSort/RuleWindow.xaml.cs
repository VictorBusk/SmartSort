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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartSort
{
    /// <summary>
    /// Interaction logic for RuleWindow.xaml
    /// </summary>
    public partial class RuleWindow : UserControl
    {
        List<Rule> rulelist = new List<Rule>();
        public RuleWindow()
        {
            InitializeComponent();
            comboBox_Rules.ItemsSource = rulelist;
            comboBox_Rules.DisplayMemberPath = "name";
            comboBox_Rules.SelectedValuePath = "name";
            rulelist.Add(new Rule("New","","","","",false,false,false,false,false,false,false));
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
