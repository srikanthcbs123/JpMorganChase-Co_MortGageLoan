﻿using System;
using System.Collections.Generic;

namespace JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;

public partial class LoginRegister
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Mobileno { get; set; }

    public string? Password { get; set; }

    public string? Username { get; set; }
}
