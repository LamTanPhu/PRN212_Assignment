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

namespace PRN212_Assignment.Books
{
    /// <summary>
    /// Interaction logic for RegisterNewBooks.xaml
    /// </summary>
    public partial class RegisterNewBooks : Window
    {
        private readonly Prn212AssignmentContext _context;

        public RegisterNewBooks()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(authorTextBox.Text) ||
                string.IsNullOrWhiteSpace(genreTextBox.Text) ||
                string.IsNullOrWhiteSpace(publicationYearTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse the input
            if (!int.TryParse(bookIdTextBox.Text, out int bookId))
            {
                MessageBox.Show("Book ID must be a valid integer.");
                return;
            }

            if (!int.TryParse(publicationYearTextBox.Text, out int publicationYear))
            {
                MessageBox.Show("Publication Year must be a valid integer.");
                return;
            }

            // Create a new Book object
            Book newBook = new Book
            {
                BookId = bookId,
                Title = titleTextBox.Text,
                Author = authorTextBox.Text,
                Genre = genreTextBox.Text,
                PublicationYear = publicationYear,
                Status = statusTextBox.Text
            };

            try
            {
                // Add the new book to the Books table and save the changes
                _context.Books.Add(newBook);
                _context.SaveChanges();

                // Inform the user and set DialogResult to true to indicate success
                MessageBox.Show("New book registered successfully!");
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show($"An error occurred while registering the book: {ex.Message}");
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
