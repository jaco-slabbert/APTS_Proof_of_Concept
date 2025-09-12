using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class Nqf
{
    public int NqfPk { get; set; }

    public int? NqfPFk { get; set; }

    public string? NqfMinimumAdmissionReq { get; set; }

    public decimal? NqfLevel { get; set; }

    public decimal? NqfMinimumCreditLevel { get; set; }

    public decimal? NqfTotalNumberCredits { get; set; }

    public decimal? NqfMinimumNumberCredits { get; set; }

    public decimal? NqfPercentageNqfcreditsFirstQual { get; set; }

    public decimal? NqfPercentageNqfcreditsSecondQual { get; set; }

    public decimal? NqfFinalYearNqfcreditsFirstQual { get; set; }

    public decimal? NqfFinalYearNqfcreditsSecondQual { get; set; }

    public decimal? NqfMinimumDurationforFt { get; set; }

    public decimal? NqfMinumumDurationPt { get; set; }

    public decimal? NqfTotalResearchCredits { get; set; }

    public DateTime? NqfCreateDate { get; set; }

    public DateTime? NqfModifyDate { get; set; }

    public string? NqfSelectionCriteria { get; set; }

    public virtual Programmes? NqfPFkNavigation { get; set; }
}
