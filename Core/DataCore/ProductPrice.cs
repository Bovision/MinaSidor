using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class ProductPrice
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public double Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;
}
