using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class HedaAptsLookupCertification
{
    public int CertPk { get; set; }

    public string CertName { get; set; } = null!;

    public bool? CertActive { get; set; }

    public DateTime? CertCreateDate { get; set; }

    public DateTime? CertModifiedDate { get; set; }
}
