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

using System;
using System.Windows;
using Repository.Models;


namespace PRN212_Assignment.Reports
{
    public partial class Reports : Window
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void BorrowingReports_Click(object sender, RoutedEventArgs e)
        {
            BorrowingReportsWindow borrowingReportsWindow = new BorrowingReportsWindow();
            WindowManager.AddWindow(borrowingReportsWindow);
            borrowingReportsWindow.Show();
            this.Close();
        }

        private void ReservationReports_Click(object sender, RoutedEventArgs e)
        {
            ReservationReportsWindow reservationReportsWindow = new ReservationReportsWindow();
            WindowManager.AddWindow(reservationReportsWindow);
            reservationReportsWindow.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.CloseAllWindows();
        }
    }
}
