using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Orderitem
{
    public int Id { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Countrycode { get; set; }

    public string? Postalcode { get; set; }

    public string? Postalarea { get; set; }

    public int? Productid { get; set; }

    public int? Customerid { get; set; }

    public DateTime? Contractstarts { get; set; }

    public DateTime? Contractends { get; set; }

    public int? Invoicecyclesinmonths { get; set; }

    public string? Bywho { get; set; }

    public string? How { get; set; }

    public string? Reference { get; set; }

    public string? Ordernr { get; set; }

    public DateTime? Orderdate { get; set; }

    public DateTime? Deleted { get; set; }

    public double? Discount { get; set; }

    public string? Currency { get; set; }

    public int? Vatid { get; set; }

    public int? Invoiceto { get; set; }

    public double? Specialprice { get; set; }

    public bool? Active { get; set; }

    public virtual Product? Product { get; set; }
}
