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
using System.Windows;

namespace PRN212_Assignment.Members
{
    /// <summary>
    /// Interaction logic for RegisterNewMember.xaml
    /// </summary>
    public partial class RegisterNewMember : Window
    {
        private readonly Prn212AssignmentContext _context;

        public RegisterNewMember()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(memberIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(contactInfoTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(memberIdTextBox.Text, out int memberId))
            {
                MessageBox.Show("Member ID must be a valid integer.");
                return;
            }

            // Create a new Member object
            Member newMember = new Member
            {
                MemberId = memberId,
                Name = nameTextBox.Text,
                ContactInformation = contactInfoTextBox.Text
            };

            try
            {
                // Add the new member to the Members table and save the changes
                _context.Members.Add(newMember);
                _context.SaveChanges();

                // Optionally, clear the text boxes
                memberIdTextBox.Clear();
                nameTextBox.Clear();
                contactInfoTextBox.Clear();

                // Optionally, show a success message
                MessageBox.Show("Member registered successfully.");

                // Set the dialog result to true to indicate success
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show($"An error occurred while registering the member: {ex.Message}");
            }
            finally
            {
                // Close the window regardless of success or failure
                this.Close();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
