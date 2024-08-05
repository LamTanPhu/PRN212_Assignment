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

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212_Assignment.Books
{
    /// <summary>
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : Window
    {
        private Prn212AssignmentContext _context;

        public Books()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();

            // Initialize statusComboBox
            statusComboBox.ItemsSource = new List<string> { "Available", "Checked Out", "Reserved" };

            // Set the ItemsSource property of the DataGrid
            RefreshBooksDataGrid();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void RefreshBooksDataGrid()
        {
            var books = _context.Books.ToList();
            booksDataGrid.ItemsSource = books;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the RegisterNewBooks form as a dialog
            RegisterNewBooks registerNewBookForm = new RegisterNewBooks();
            bool? dialogResult = registerNewBookForm.ShowDialog();

            // If the dialog result is true, refresh the DataGrid
            if (dialogResult == true)
            {
                RefreshBooksDataGrid();
            }
        }

        private void EditBookButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Book object from the DataGrid
            Book selectedBook = (Book)booksDataGrid.SelectedItem;

            if (selectedBook != null)
            {
                // Update the properties of the selectedBook object based on the text boxes
                selectedBook.Title = titleTextBox.Text;
                selectedBook.Author = authorTextBox.Text;
                selectedBook.Genre = genreTextBox.Text;
                selectedBook.PublicationYear = int.Parse(publicationYearTextBox.Text);
                selectedBook.Status = statusComboBox.Text;

                // Save the changes to the database
                _context.SaveChanges();

                // Refresh the DataGrid
                RefreshBooksDataGrid();
            }
        }

        private void DeleteBookButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Book object from the DataGrid
            Book selectedBook = (Book)booksDataGrid.SelectedItem;

            if (selectedBook != null)
            {
                // Ask the user to confirm the deletion
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    // If the user confirmed, remove the selected book from the Books table
                    _context.Books.Remove(selectedBook);

                    // Save the changes to the database
                    _context.SaveChanges();

                    // Refresh the DataGrid
                    RefreshBooksDataGrid();
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the search query from the TextBox
            string searchQuery = searchTextBox.Text.ToLower();

            // Filter the books based on the search query
            var filteredBooks = _context.Books.Where(b =>
                b.Title.ToLower().Contains(searchQuery) ||
                b.Author.ToLower().Contains(searchQuery) ||
                b.Genre.ToLower().Contains(searchQuery) ||
                b.PublicationYear.ToString().Contains(searchQuery)
            ).ToList();

            // Set the ItemsSource property of the DataGrid
            booksDataGrid.ItemsSource = filteredBooks;
        }

        private void BooksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected Book object from the DataGrid
            Book selectedBook = (Book)booksDataGrid.SelectedItem;

            // If a book is selected, display its details in the text boxes
            if (selectedBook != null)
            {
                bookIdTextBox.Text = selectedBook.BookId.ToString();
                titleTextBox.Text = selectedBook.Title;
                authorTextBox.Text = selectedBook.Author;
                genreTextBox.Text = selectedBook.Genre;
                publicationYearTextBox.Text = selectedBook.PublicationYear.ToString();

                // Set the selected status in the combobox
                statusComboBox.SelectedItem = selectedBook.Status;
            }
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
