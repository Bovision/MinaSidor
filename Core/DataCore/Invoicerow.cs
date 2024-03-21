using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Invoicerow
{
    public int Id { get; set; }

    public int Invoiceid { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public double Quantity { get; set; }

    public string? Unit { get; set; }

    public double Vatpct { get; set; }

    public double Price { get; set; }

    public string? Currency { get; set; }

    public string? Description { get; set; }

    public double Discount { get; set; }
}
