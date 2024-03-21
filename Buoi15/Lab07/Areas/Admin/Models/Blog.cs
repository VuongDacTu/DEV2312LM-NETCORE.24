﻿using System;
using System.Collections.Generic;

namespace Lab07.Areas.Admin.Models;

public partial class Blog
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
