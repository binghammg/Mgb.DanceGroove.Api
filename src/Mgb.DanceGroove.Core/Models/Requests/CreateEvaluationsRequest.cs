using System.ComponentModel.DataAnnotations;

namespace Mgb.DanceGroove.Core.Models.Requests;

public class CreateEvaluationsRequest
{
    [Required]
    public string DestinationPath { get; set; }

    [Required]
    public string SourcePath { get; set; }
}
