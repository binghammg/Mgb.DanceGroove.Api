namespace Mgb.DanceGroove.Core.Models.Responses;

public class BaseResponse
{
    public List<string> Errors { get; set; }

    public int StatusCode { get; set; }
}
