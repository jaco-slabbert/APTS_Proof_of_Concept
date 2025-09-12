using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class VPersonnel
{
    public decimal AuthPk { get; set; }

    public string? AuthTitle { get; set; }

    public string? AuthName { get; set; }

    public string? AuthSurname { get; set; }

    public string? AuthInstitution { get; set; }

    public decimal AuthDepartment { get; set; }

    public decimal? AuthFaculty { get; set; }

    public decimal AuthReferenceNumber { get; set; }

    public string AuthGender { get; set; } = null!;

    public string? AuthGroup { get; set; }

    public string AuthNationality { get; set; } = null!;

    public string? AuthEmail { get; set; }

    public int? AuthYear { get; set; }
}
