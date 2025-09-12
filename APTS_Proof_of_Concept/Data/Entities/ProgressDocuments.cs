using System;
using System.Collections.Generic;

namespace APTS_Proof_of_Concept.Data.Entities;

public partial class ProgressDocuments
{
    public int PrgdPk { get; set; }

    public int? PrgdPrgFk { get; set; }

    public int? PrgdPFk { get; set; }

    public string? PrgdFileName { get; set; }

    public string? PrgdFilePath { get; set; }

    public DateTime? PrgdCreateDate { get; set; }

    public DateTime? PrgdModifyDate { get; set; }

    public int PrgdType { get; set; }

    public byte[]? PrgdFileByte { get; set; }

    public string? PrgdContentType { get; set; }

    public string? PrgdFileExtension { get; set; }
}
