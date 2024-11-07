﻿using System;
using System.Collections.Generic;

namespace Euro.DAL.Models;

public partial class Uefaaccount
{
    public int AccountId { get; set; }

    public string AccountPassword { get; set; } = null!;

    public string? AccountEmail { get; set; }

    public string AccountDescription { get; set; } = null!;

    public int? Role { get; set; }
}