using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Countrycode { get; set; }

    public string? Postalcode { get; set; }

    public string? Postalarea { get; set; }

    public string? Deliveryaddress1 { get; set; }

    public string? Deliveryaddress2 { get; set; }

    public string? Deliveryaddress3 { get; set; }

    public string? Deliverycountrycode { get; set; }

    public string? Deliverypostalcode { get; set; }

    public string? Deliverypostalarea { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Orgnr { get; set; }

    public string? Vatno { get; set; }

    public string? Contactemail { get; set; }

    public string? Mailingemail { get; set; }

    public string? Webadress { get; set; }

    public string? Password { get; set; }

    public string? Passwordservices { get; set; }

    public string? Currency { get; set; }

    public int Export { get; set; }

    public string? ContactName { get; set; }

    public int SpecialExpFee { get; set; }

    public double SpecialDiscount { get; set; }

    public string? Logotype { get; set; }

    public string? InvoiceEmail { get; set; }

    public bool ToBlocket { get; set; }

    public string? System { get; set; }

    public bool IsActiveViaOrders { get; set; }

    public bool IsActiveViaInvoice { get; set; }

    public int? InvoicedAmount2015 { get; set; }

    public bool IsSpider { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
    }
