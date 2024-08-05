using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? BookId { get; set; }

    public int? MemberId { get; set; }

    public DateOnly? ReservationDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Member? Member { get; set; }
}
