using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StatusBlock
{
    public long SbPk { get; set; }

    public long? SbScFk { get; set; }

    public string? SbName { get; set; }

    public string? SbDescription { get; set; }

    public int? SbOrdering { get; set; }

    public string? SbColour { get; set; }

    public int? SbEditable { get; set; }

    public DateTime? SbCreateDate { get; set; }

    public DateTime? SbModifyDate { get; set; }

    public int? SbDefault { get; set; }

    public int? SbLocked { get; set; }

    public int? SbClosed { get; set; }

    public int? SbEnabled { get; set; }

    public int? SbAltCategory { get; set; }

    public int? SbAptsStatus { get; set; }
}
