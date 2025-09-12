using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class PAdditionalFieldInPutType
{
    public int InputPk { get; set; }

    public int? InputVal { get; set; }

    public string? InputText { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModofiedDate { get; set; }

    public bool? IsInActive { get; set; }
}
