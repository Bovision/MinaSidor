using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Ovfakturaunderlag
{
    public int LOvfakturaunderlagId { get; set; }

    public short NMaklarid { get; set; }

    public int LObjektnr { get; set; }

    public DateTime DatDatum { get; set; }

    public bool BFakturerad { get; set; }

    public short NTyp { get; set; }

    public short? NLankom { get; set; }

    public string? SOmrade { get; set; }

    public string? SAdress { get; set; }

    public DateTime? DatFakturadatum { get; set; }

    public short? NFakturatyp { get; set; }

    public DateTime? DatStop { get; set; }
}
