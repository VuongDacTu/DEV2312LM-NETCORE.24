using System;
using System.Collections.Generic;

namespace Lesson10CustomAtuhorize.Models.DF;

public partial class ProductImage
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public string? Image { get; set; }
}
