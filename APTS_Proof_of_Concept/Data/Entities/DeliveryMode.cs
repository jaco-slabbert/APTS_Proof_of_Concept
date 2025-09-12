using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class DeliveryMode
{
    public int DmPk { get; set; }

    public string? DmName { get; set; }

    public string? DmDescription { get; set; }

    public string? DmPlaceholder { get; set; }

    public DateTime? DmCreateDate { get; set; }

    public DateTime? DmModifyDate { get; set; }

    public bool? DmActive { get; set; }
}
