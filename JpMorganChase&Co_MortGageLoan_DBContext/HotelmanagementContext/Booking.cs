using System;
using System.Collections.Generic;

namespace JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;

public partial class Booking
{
    public int? Id { get; set; }

    public string? CustomerName { get; set; }

    public string? Location { get; set; }

    public DateOnly? Date { get; set; }
}
