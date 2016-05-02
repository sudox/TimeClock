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

namespace Time_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeSheet sheet;

        public MainWindow()
        {
            InitializeComponent();
            sheet = new TimeSheet();
            sheet.setUser("Michael Griffith");
        }

        private void Clock_Out(object sender, RoutedEventArgs e)
        {
            string punchTime = DateTime.Now.ToString("h:mm:ss tt");
            if (uname.Text == "")
                MessageBox.Show("Select a user!");
            else
            {
                MessageBox.Show(uname.Text + " was clocked " + sheet.punchType() + " at: " + punchTime);
                sheet.punch(punchTime);
            }
        }

        private void Timesheet_Check(object sender, RoutedEventArgs e)
        {
            if (uname.Text == "")
                MessageBox.Show("Select a user!");
            else
                MessageBox.Show(sheet.checkCard(uname.Text));
        }
    }
}
