using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Borrowing
{
    public int BorrowId { get; set; }

    public int? BookId { get; set; }

    public int? MemberId { get; set; }

    public DateOnly? BorrowDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Member? Member { get; set; }
}
