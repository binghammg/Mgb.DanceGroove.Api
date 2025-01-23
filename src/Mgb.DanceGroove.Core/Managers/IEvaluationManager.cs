using Mgb.DanceGroove.Core.Models.Requests;
using Mgb.DanceGroove.Core.Models.Responses;

namespace Mgb.DanceGroove.Core.Managers;

public interface IEvaluationManager
{
    Task<CreateEvaluationsResponse> CreateDancerEvaluations(CreateEvaluationsRequest createEvaluationRequest);
}
