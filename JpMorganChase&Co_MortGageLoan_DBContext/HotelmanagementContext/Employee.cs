using System;
using System.Collections.Generic;

namespace JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;

public partial class Employee
{
    public int Empid { get; set; }

    public string? Empname { get; set; }

    public decimal? Empsalary { get; set; }
}
