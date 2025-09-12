using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Nqf1
{
    public int NqfPFk { get; set; }

    public double? NqfLevel { get; set; }

    public double NqfTotalNumberCredits { get; set; }
}
