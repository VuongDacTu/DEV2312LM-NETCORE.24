using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab07.Areas.Admin.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte? Status { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? Created { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
