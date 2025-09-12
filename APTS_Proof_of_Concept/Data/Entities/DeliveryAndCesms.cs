using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class DeliveryAndCesms
{
    public int DcsmPk { get; set; }

    public int? DcsmPFk { get; set; }

    public string? DcsmSiteOfDelivery { get; set; }

    public int? DcsmModeOfDelivery { get; set; }

    public string? DcsmFtpt { get; set; }

    public string? DcsmCesmMfos { get; set; }

    public string? DcsmCesmFirstOrder { get; set; }

    public string? DcsmCesmSecondOrder { get; set; }

    public int? DcsmQualificationDesc { get; set; }

    public bool? DcsmCesmFirstOrderVerify { get; set; }

    public bool? DcsmCesmSecondOrderVerify { get; set; }

    public DateTime? DcsmCreateDate { get; set; }

    public DateTime? DcsmModifyDate { get; set; }

    public virtual Programmes? DcsmPFkNavigation { get; set; }
}
