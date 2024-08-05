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

namespace PRN212_Assignment
{
    public partial class HomeScreen : Window
    {
        public HomeScreen()
        {
            InitializeComponent();
            WindowManager.AddWindow(this);
        }

        private void ManageBooksButton_Click(object sender, RoutedEventArgs e)
        {
            var booksScreen = new Books.Books();
            booksScreen.Show();
            WindowManager.AddWindow(booksScreen);
        }

        private void ManageMembersButton_Click(object sender, RoutedEventArgs e)
        {
            var membersScreen = new Members.Members();
            membersScreen.Show();
            WindowManager.AddWindow(membersScreen);
        }

        private void ViewReportsButton_Click(object sender, RoutedEventArgs e)
        {
            var reportsScreen = new Reports.Reports();
            reportsScreen.Show();
            WindowManager.AddWindow(reportsScreen);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.CloseAllWindows();
            var loginScreen = new MainWindow();
            loginScreen.Show();
        }
    }
}

