using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public string? Notes { get; set; }

    public string? Type { get; set; }

    public string? Rules { get; set; }

    public int? Vatid { get; set; }

    public int? Pricetype { get; set; }

    public string? Unit { get; set; }

    public string? Currency { get; set; }

    public int InvoiceCyclesInMoths { get; set; }

    public int OrderCanOverridePrice { get; set; }

    public DateTime Deleted { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
