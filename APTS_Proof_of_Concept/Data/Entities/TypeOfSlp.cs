using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class TypeOfSlp
{
    public int TslpPk { get; set; }

    public int? TslpSlpFk { get; set; }

    public int? TslpModeOfProvisioning { get; set; }

    public bool? TslpCreditBearing { get; set; }

    public bool? TslpNonCreditBearing { get; set; }

    public bool? TslpAssessStudentCompetencies { get; set; }

    public bool? TslpParticipantsAttendanceRequired { get; set; }

    public bool? TslpIsCollaborativeJointSlp { get; set; }

    public bool? TslpIsSlpthirdPartyCollab { get; set; }

    public string? TslpThirdPartyCollabName { get; set; }

    public decimal? TslpCostAssociated { get; set; }

    public bool? TslpIsSlpacceptedForCpd { get; set; }

    public bool? TslpIsSlpthirdPartyCollabCpd { get; set; }

    public string? TslpThirdPartyCollabNameCpd { get; set; }

    public virtual ShortLearningProgramme? TslpSlpFkNavigation { get; set; }
}
