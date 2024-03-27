using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Customernote
{
    public int Id { get; set; }

    public int? Customerid { get; set; }

    public string? Text { get; set; }

    public DateTime? Created { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Deleted { get; set; }
}
