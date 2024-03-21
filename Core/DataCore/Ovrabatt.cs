using System;
using System.Collections.Generic;

namespace Core.DataCore;

public partial class Ovrabatt
{
    public int Id { get; set; }

    public int? NMaklarid { get; set; }

    public int? Rabattprocent { get; set; }

    public DateTime? DatUpphor { get; set; }

    public int? RabattprocentInfo { get; set; }

    public int? Pakettyp { get; set; }

    public bool? BAktiv { get; set; }

    public DateTime? DatSkapad { get; set; }

    public DateTime? DatAndrad { get; set; }

    public string? SKommentar { get; set; }
}
