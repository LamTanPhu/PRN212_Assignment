using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Repository.Models;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Prn212AssignmentContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordBox.Password;

            // Hash the entered password
            string enteredPasswordHash = BitConverter.ToString(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(enteredPassword))).Replace("-", "");

            // Query the Staff table to find a record with the entered username and hashed password
            var staffMember = _context.Staff.SingleOrDefault(s => s.Username == enteredUsername && s.PasswordHash == enteredPasswordHash);

            if (staffMember != null)
            {
                // Login successful
                if (staffMember.Role == "Manager")
                {
                    // If the user is a Manager, open the HomeScreenManager
                    HomeScreenManager homeScreenManager = new HomeScreenManager();
                    homeScreenManager.Show();
                }
                else if (staffMember.Role == "Librarian")
                {
                    // If the user is a Librarian, open the HomeScreen
                    HomeScreen homeScreen = new HomeScreen();
                    homeScreen.Show();
                }
                this.Close();
            }
            else
            {
                // Login failed
                errorMessageTextBlock.Text = "Invalid username or password.";
            }
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the Register form
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }


    }
}
