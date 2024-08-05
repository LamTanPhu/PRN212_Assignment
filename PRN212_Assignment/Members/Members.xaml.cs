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
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212_Assignment.Members
{
    /// <summary>
    /// Interaction logic for Members.xaml
    /// </summary>
    public partial class Members : Window
    {
        private Prn212AssignmentContext _context;

        public Members()
        {
            InitializeComponent();

            // Instantiate _context
            _context = new Prn212AssignmentContext();

            // Retrieve the members from the database
            var members = _context.Members.ToList();

            // Set the ItemsSource property of the DataGrid
            membersDataGrid.ItemsSource = members;

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the RegisterNewMember form as a dialog
            RegisterNewMember registerNewMemberForm = new RegisterNewMember();
            bool? dialogResult = registerNewMemberForm.ShowDialog();

            // If the dialog result is true, refresh the DataGrid
            if (dialogResult == true)
            {
                // Clear the selection in the DataGrid
                membersDataGrid.SelectedItem = null;

                // Refresh the DataGrid
                membersDataGrid.ItemsSource = _context.Members.ToList();
            }
        }

        private void EditMemberButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Member object from the DataGrid
            Member selectedMember = (Member)membersDataGrid.SelectedItem;

            // Update the properties of the selectedMember object based on the text boxes
            selectedMember.MemberId = int.Parse(memberIdTextBox.Text);
            selectedMember.Name = nameTextBox.Text;
            selectedMember.ContactInformation = contactInfoTextBox.Text;

            // Save the changes to the database
            _context.SaveChanges();

            // Refresh the DataGrid
            membersDataGrid.ItemsSource = _context.Members.ToList();
        }

        private void DeleteMemberButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Member object from the DataGrid
            Member selectedMember = (Member)membersDataGrid.SelectedItem;

            // Ask the user to confirm the deletion
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                // If the user confirmed, remove the selected member from the Members table
                _context.Members.Remove(selectedMember);

                // Save the changes to the database
                _context.SaveChanges();

                // Refresh the DataGrid
                membersDataGrid.ItemsSource = _context.Members.ToList();
            }
        }

        private void MembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected Member object from the DataGrid
            Member selectedMember = (Member)membersDataGrid.SelectedItem;

            // Check if selectedMember is not null
            if (selectedMember != null)
            {
                // Update the text boxes with the selected member's details
                memberIdTextBox.Text = selectedMember.MemberId.ToString();
                nameTextBox.Text = selectedMember.Name;
                contactInfoTextBox.Text = selectedMember.ContactInformation;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the search query from the TextBox
            string searchQuery = searchTextBox.Text.ToLower();

            // Filter the members based on the search query
            var filteredMembers = _context.Members.Where(m =>
                m.MemberId.ToString().Contains(searchQuery) ||
                m.Name.ToLower().Contains(searchQuery) ||
                m.ContactInformation.ToLower().Contains(searchQuery)
            ).ToList();

            // Set the ItemsSource property of the DataGrid
            membersDataGrid.ItemsSource = filteredMembers;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
