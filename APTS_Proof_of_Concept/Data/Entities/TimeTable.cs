using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class TimeTable
{
    public int TtPk { get; set; }

    public int? TtMdlFk { get; set; }

    public string? TtCampus { get; set; }

    public int? TtTotalStudents { get; set; }

    public int? TtCVenueSize { get; set; }

    public int? TtCPeriodGroups { get; set; }

    public int? TtCVenueType { get; set; }

    public string? TtCComment { get; set; }

    public int? TtPVenueSize { get; set; }

    public int? TtPPeriodGroups { get; set; }

    public int? TtPVenueType { get; set; }

    public string? TtPComment { get; set; }

    public int? TtTVenueSize { get; set; }

    public int? TtTPeriodGroups { get; set; }

    public int? TtTVenueType { get; set; }

    public string? TtTComment { get; set; }
}
