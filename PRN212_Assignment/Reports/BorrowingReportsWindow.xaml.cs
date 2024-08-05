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
    public partial class BorrowingReportsWindow : Window
    {
        private readonly Prn212AssignmentContext _context;

        public BorrowingReportsWindow()
        {
            InitializeComponent();
            _context = new Prn212AssignmentContext();
            LoadBorrowings();

            // Add this window instance to WindowManager
            WindowManager.AddWindow(this);
        }

        private void LoadBorrowings()
        {
            dgBorrowings.ItemsSource = _context.Borrowings.ToList();
        }

        private void dgBorrowings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgBorrowings.SelectedItem is Borrowing selectedBorrowing)
            {
                txtBorrowID.Text = selectedBorrowing.BorrowId.ToString();
                txtBookID.Text = selectedBorrowing.BookId.ToString();
                txtMemberID.Text = selectedBorrowing.MemberId.ToString();

                dpBorrowDate.SelectedDate = selectedBorrowing.BorrowDate?.ToDateTime(TimeOnly.MinValue);
                dpReturnDate.SelectedDate = selectedBorrowing.ReturnDate?.ToDateTime(TimeOnly.MinValue);
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = dpStartDate.SelectedDate ?? DateTime.MinValue;
            DateTime endDate = dpEndDate.SelectedDate ?? DateTime.MaxValue;

            var filtered = _context.Borrowings
                .Where(b => b.BorrowDate.HasValue &&
                            b.BorrowDate >= DateOnly.FromDateTime(startDate) &&
                            b.BorrowDate <= DateOnly.FromDateTime(endDate))
                .ToList();

            dgBorrowings.ItemsSource = filtered;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (dgBorrowings.SelectedItem is Borrowing selectedBorrowing)
            {
                selectedBorrowing.BookId = int.Parse(txtBookID.Text);
                selectedBorrowing.MemberId = int.Parse(txtMemberID.Text);
                selectedBorrowing.BorrowDate = dpBorrowDate.SelectedDate.HasValue
                    ? DateOnly.FromDateTime(dpBorrowDate.SelectedDate.Value)
                    : selectedBorrowing.BorrowDate;
                selectedBorrowing.ReturnDate = dpReturnDate.SelectedDate.HasValue
                    ? DateOnly.FromDateTime(dpReturnDate.SelectedDate.Value)
                    : selectedBorrowing.ReturnDate;

                _context.SaveChanges();
                LoadBorrowings(); // Refresh the data grid
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
            LoadBorrowings();
        }

        private void AddBorrowing_Click(object sender, RoutedEventArgs e)
        {
            var createBorrowingWindow = new CreateBorrowingReports();
            createBorrowingWindow.ShowDialog();
            LoadBorrowings(); // Refresh the data grid after adding a borrowing
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            // Remove this window instance from WindowManager
            WindowManager.OpenWindows.Remove(this);
        }
    }
}
