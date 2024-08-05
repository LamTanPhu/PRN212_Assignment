using Microsoft.EntityFrameworkCore;
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

using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PRN212_Assignment
{
    /// <summary>
    /// Interaction logic for RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        private readonly Prn212AssignmentContext _context;

        public RegisterForm()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered StaffID, username, password, name, and role
            int enteredStaffId = Int32.Parse(staffIdTextBox.Text);
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordBox.Password;
            string enteredName = nameTextBox.Text;
            string enteredRole = ((ComboBoxItem)roleComboBox.SelectedItem).Content.ToString();

            // Hash the entered password
            string enteredPasswordHash = ComputeHash(enteredPassword);

            // Check if a user with the entered username already exists
            var existingUser = _context.Staff.SingleOrDefault(s => s.Username == enteredUsername);

            if (existingUser == null)
            {
                // User does not exist, so create a new user
                var newUser = new Staff
                {
                    StaffId = enteredStaffId,
                    Name = enteredName,
                    Username = enteredUsername,
                    PasswordHash = enteredPasswordHash,
                    Role = enteredRole
                };
                _context.Staff.Add(newUser);
                _context.SaveChanges();

                errorMessageTextBlock.Text = "Registration successful.";
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Close this window
                Close();
            }
            else
            {
                // User already exists
                errorMessageTextBlock.Text = "Username already taken.";
            }
        }

        private string ComputeHash(string input)
        {
            // Hash the entered password using SHA256
            byte[] hashBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
