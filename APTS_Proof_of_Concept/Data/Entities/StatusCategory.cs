using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class StatusCategory
{
    public long ScPk { get; set; }

    public string? ScName { get; set; }

    public string? ScDescription { get; set; }

    public int? ScOrdering { get; set; }

    public string? ScColour { get; set; }

    public bool? ScEditable { get; set; }

    public DateTime? ScCreateDate { get; set; }

    public DateTime? ScModifyDate { get; set; }

    public bool? ScDefault { get; set; }

    public bool ScLocked { get; set; }

    public bool? ScClosed { get; set; }

    public bool? ScEnabled { get; set; }

    public bool? ScAltCategory { get; set; }

    public bool? ScAptsStatus { get; set; }

    public long? ScGroupId { get; set; }

    public int? ScPrevPk { get; set; }

    public virtual StatusGroup? ScGroup { get; set; }
}
