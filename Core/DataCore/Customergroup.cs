using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Customergroup
{
    public int Id { get; set; }

    public int? Customerid { get; set; }

    public int? Groupid { get; set; }

    public DateTime? Created { get; set; }
}
