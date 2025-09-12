using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class SiteOfDelivery
{
    public int SodPk { get; set; }

    public string? SodName { get; set; }

    public string? SodDescription { get; set; }

    public DateTime? SodCreateDate { get; set; }

    public DateTime? SodModifyDate { get; set; }
}
