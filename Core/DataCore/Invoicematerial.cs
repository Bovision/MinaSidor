using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Invoicematerial
{
    public int Id { get; set; }

    public int Customerid { get; set; }

    public int Invoiceto { get; set; }

    public DateTime Period { get; set; }

    public DateTime Created { get; set; }

    public int Productid { get; set; }

    public string Productcode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Details { get; set; } = null!;

    public double Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double Vatpct { get; set; }

    public double Amount { get; set; }

    public string Currencycode { get; set; } = null!;

    public double Discountamount { get; set; }

    public DateTime Sent { get; set; }

    public string? Reference { get; set; }

    public int Invoiceid { get; set; }
}
