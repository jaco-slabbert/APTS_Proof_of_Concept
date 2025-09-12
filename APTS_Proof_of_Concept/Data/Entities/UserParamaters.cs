using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class UserParamaters
{
    public int UpPk { get; set; }

    public string? UpUserName { get; set; }

    public string? UpParameterName { get; set; }

    public int? UpParameterKey { get; set; }

    public string? UpValue { get; set; }

    public DateTime? UpCreateDate { get; set; }

    public DateTime? UpModifiedDate { get; set; }
}
