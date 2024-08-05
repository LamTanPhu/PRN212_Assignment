using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Genre { get; set; }

    public int? PublicationYear { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
