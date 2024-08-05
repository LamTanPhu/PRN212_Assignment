using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string? Name { get; set; }

    public string? ContactInformation { get; set; }

    public virtual ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
