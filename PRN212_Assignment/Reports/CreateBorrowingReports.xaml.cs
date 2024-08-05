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

namespace PRN212_Assignment.Reports
{
    public partial class CreateBorrowingReports : Window
    {
        private readonly Prn212AssignmentContext _context;

        public CreateBorrowingReports()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();
        }

        private void AddBorrowing_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int bookID = int.Parse(txtBookID.Text);
                int memberID = int.Parse(txtMemberID.Text);
                DateOnly borrowDate = DateOnly.FromDateTime(dpBorrowDate.SelectedDate.Value);
                DateOnly? returnDate = dpReturnDate.SelectedDate.HasValue
                    ? DateOnly.FromDateTime(dpReturnDate.SelectedDate.Value)
                    : (DateOnly?)null;

                // Create a new borrowing record
                var borrowing = new Borrowing
                {
                    BookId = bookID,
                    MemberId = memberID,
                    BorrowDate = borrowDate,
                    ReturnDate = returnDate
                };

                _context.Borrowings.Add(borrowing);

                // Update the book's status to "Checked Out"
                var book = _context.Books.Find(bookID);
                if (book != null)
                {
                    book.Status = "Checked Out";
                }

                _context.SaveChanges();
                MessageBox.Show("Borrowing added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
