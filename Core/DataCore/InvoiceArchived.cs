using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class InvoiceArchived
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    public DateTime ArchiveDate { get; set; }

    public string? Invoice { get; set; }
}
