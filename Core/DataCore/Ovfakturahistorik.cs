using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Ovfakturahistorik
{
    public int Year { get; set; }

    public int Month { get; set; }

    public int NMaklarid { get; set; }

    public int? NOvAnnonspaket { get; set; }

    public int? NSumma { get; set; }

    public int? NAntal { get; set; }
}
