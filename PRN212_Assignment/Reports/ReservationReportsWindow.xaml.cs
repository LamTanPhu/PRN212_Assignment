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
using System.Linq;
using Repository.Models; // Add this using statement if not already present

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212_Assignment.Reports
{
    public partial class ReservationReportsWindow : Window
    {
        private readonly Prn212AssignmentContext _context;

        public ReservationReportsWindow()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();
            LoadReservations();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void LoadReservations()
        {
            dgReservations.ItemsSource = _context.Reservations.ToList();
        }

        private void dgReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgReservations.SelectedItem is Reservation selectedReservation)
            {
                txtReservationID.Text = selectedReservation.ReservationId.ToString();
                txtBookID.Text = selectedReservation.BookId.ToString();
                txtMemberID.Text = selectedReservation.MemberId.ToString();

                dpReservationDate.SelectedDate = selectedReservation.ReservationDate?.ToDateTime(TimeOnly.MinValue);
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = dpStartDate.SelectedDate ?? DateTime.MinValue;
            DateTime endDate = dpEndDate.SelectedDate ?? DateTime.MaxValue;

            var filtered = _context.Reservations
                .Where(r => r.ReservationDate.HasValue &&
                            r.ReservationDate >= DateOnly.FromDateTime(startDate) &&
                            r.ReservationDate <= DateOnly.FromDateTime(endDate))
                .ToList();

            dgReservations.ItemsSource = filtered;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (dgReservations.SelectedItem is Reservation selectedReservation)
            {
                selectedReservation.BookId = int.Parse(txtBookID.Text);
                selectedReservation.MemberId = int.Parse(txtMemberID.Text);
                selectedReservation.ReservationDate = dpReservationDate.SelectedDate.HasValue
                    ? DateOnly.FromDateTime(dpReservationDate.SelectedDate.Value)
                    : (DateOnly?)null;

                _context.SaveChanges();
                LoadReservations(); // Refresh the data grid
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to leave?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var reportsWindow = new Reports();
                reportsWindow.Show();
                Close();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            dpStartDate.SelectedDate = null;
            dpEndDate.SelectedDate = null;
            LoadReservations();
        }

        private void AddReservation_Click(object sender, RoutedEventArgs e)
        {
            var createReservationWindow = new CreateReservationReports();
            createReservationWindow.ShowDialog();
            LoadReservations(); // Refresh the data grid after adding a reservation
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
