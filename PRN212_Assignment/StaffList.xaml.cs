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

using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212_Assignment
{
    public partial class StaffList : Window
    {
        private Prn212AssignmentContext _context;
        private List<string> _validRoles = new List<string> { "Librarian", "Manager" };

        public StaffList()
        {
            InitializeComponent();

            // Instantiate _context
            _context = new Prn212AssignmentContext();

            // Retrieve staff members from the database
            var staffMembers = _context.Staff.ToList();
            roleComboBox.ItemsSource = _validRoles;

            // Set the ItemsSource property of the DataGrid
            staffDataGrid.ItemsSource = staffMembers;

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Staff object from the DataGrid
            Staff selectedStaff = (Staff)staffDataGrid.SelectedItem;

            // Update the properties of the selectedStaff object based on the text boxes
            selectedStaff.StaffId = int.Parse(staffIdTextBox.Text);
            selectedStaff.Name = nameTextBox.Text;
            selectedStaff.Username = usernameTextBox.Text;
            selectedStaff.Role = roleComboBox.SelectedItem.ToString(); // Get the selected role from the combobox

            // Save the changes to the database
            _context.SaveChanges();

            // Refresh the DataGrid
            staffDataGrid.ItemsSource = _context.Staff.ToList();
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Staff object from the DataGrid
            Staff selectedStaff = (Staff)staffDataGrid.SelectedItem;

            // Ask the user to confirm the deletion
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                // If the user confirmed, remove the selected staff member from the Staff table
                _context.Staff.Remove(selectedStaff);

                // Save the changes to the database
                _context.SaveChanges();

                // Refresh the DataGrid
                staffDataGrid.ItemsSource = _context.Staff.ToList();
            }
        }

        private void StaffDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Staff selectedStaff = (Staff)staffDataGrid.SelectedItem;
            if (selectedStaff != null)
            {
                staffIdTextBox.Text = selectedStaff.StaffId.ToString();
                nameTextBox.Text = selectedStaff.Name;
                usernameTextBox.Text = selectedStaff.Username;
                roleComboBox.SelectedItem = selectedStaff.Role; // Set the selected role
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the search query from the TextBox
            string searchQuery = searchTextBox.Text.ToLower();

            // Filter staff members based on the search query
            var filteredStaff = _context.Staff.Where(s =>
                s.StaffId.ToString().Contains(searchQuery) ||
                s.Name.ToLower().Contains(searchQuery) ||
                s.Username.ToLower().Contains(searchQuery) ||
                s.Role.ToLower().Contains(searchQuery)
            ).ToList();

            // Set the ItemsSource property of the DataGrid
            staffDataGrid.ItemsSource = filteredStaff;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
