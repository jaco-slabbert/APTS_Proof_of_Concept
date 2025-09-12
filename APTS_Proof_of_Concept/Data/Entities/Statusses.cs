using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Statusses
{
    public long SPk { get; set; }

    public long? SSFk { get; set; }

    public string? SName { get; set; }

    public string? SDescription { get; set; }

    public int? SOrdering { get; set; }

    public string? SColour { get; set; }

    public bool? SEditable { get; set; }

    public DateTime? SCreateDate { get; set; }

    public DateTime? SModifyDate { get; set; }

    public bool? SDefault { get; set; }

    public bool SLocked { get; set; }

    public bool? SClosed { get; set; }

    public bool? SEnabled { get; set; }

    public bool? SAltCategory { get; set; }

    public bool? SAptsStatus { get; set; }

    public long? SGroupId { get; set; }

    public bool? SIsInActive { get; set; }

    public string? SSystemReference { get; set; }

    public virtual StatusGroup? SGroup { get; set; }
}
