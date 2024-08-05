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
    public partial class CreateReservationReports : Window
    {
        private readonly Prn212AssignmentContext _context;

        public CreateReservationReports()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();
        }

        private void AddReservation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int bookID = int.Parse(txtBookID.Text);
                int memberID = int.Parse(txtMemberID.Text);
                DateOnly reservationDate = DateOnly.FromDateTime(dpReservationDate.SelectedDate.Value);

                // Create a new reservation
                var reservation = new Reservation
                {
                    BookId = bookID,
                    MemberId = memberID,
                    ReservationDate = reservationDate
                };

                _context.Reservations.Add(reservation);

                // Update the book's status to "Reserved"
                var book = _context.Books.Find(bookID);
                if (book != null)
                {
                    book.Status = "Reserved";
                }

                _context.SaveChanges();
                MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
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

