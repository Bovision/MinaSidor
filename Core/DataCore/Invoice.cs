using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Core.DataCore;

public partial class Invoice
{
    [JsonIgnore]
    public virtual Customer Customer { get; set; }
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string Countrycode { get; set; } = null!;

    public string? Postalcode { get; set; }

    public string? Postalarea { get; set; }

    public string? Deliveryname { get; set; }

    public string? Deliveryaddress1 { get; set; }

    public string? Deliveryaddress2 { get; set; }

    public string? Deliveryaddress3 { get; set; }

    public string? Deliverycountrycode { get; set; }

    public string? Deliverypostalcode { get; set; }

    public string? Deliverypostalarea { get; set; }

    public bool? Iscredit { get; set; }

    public int Invoiceid { get; set; }

    public int Customerid { get; set; }

    public string? Customervat { get; set; }

    public string? Ourvat { get; set; }

    public string? Reference { get; set; }

    public string? Deliveryterms { get; set; }

    public string? Deliverymode { get; set; }

    public string? Termspayment { get; set; }

    public DateTime Duedate { get; set; }

    public string? Ourreference { get; set; }

    public string? Orderno { get; set; }

    public string? Domicile { get; set; }

    public double Freight { get; set; }

    public double Expfee { get; set; }

    public double Vat { get; set; }

    public double Evenout { get; set; }

    public double Sum { get; set; }

    public double Totalsum { get; set; }

    public string Currency { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime Invoicedate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Sent { get; set; }

    public DateTime Reminder { get; set; }

    public DateTime Claim { get; set; }

    public DateTime? Payed { get; set; }

    public DateTime Deleted { get; set; }

    public DateTime Credit { get; set; }

    public int PertainsToCredit { get; set; }

    public string ExternalSystem { get; set; } = null!;

    public string ExternalId { get; set; } = null!;

}
