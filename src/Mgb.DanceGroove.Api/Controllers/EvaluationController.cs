using Mgb.DanceGroove.Core.Managers;
using Mgb.DanceGroove.Core.Models.Requests;
using Mgb.DanceGroove.Core.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mgb.DanceGroove.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EvaluationController : ControllerBase
{
    private readonly IEvaluationManager _evaluationManager;
    private readonly ILogger<EvaluationController> _logger;

    public EvaluationController(
        IEvaluationManager evaluationManager,
        ILogger<EvaluationController> logger)
    {
        _evaluationManager = evaluationManager ?? throw new ArgumentNullException(nameof(evaluationManager));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Reads a file of dancer evaluations and creates individual dancer evaluation documents that can be emailed.
    /// </summary>
    /// <param name="createEvaluationRequest"></param>
    /// <returns></returns>
    [HttpPost(Name = "CreateDancerEvaluations")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateEvaluationsResponse>> CreateDancerEvaluations(CreateEvaluationsRequest createEvaluationsRequest)
    {
        var createEvaluationResponse = new CreateEvaluationsResponse();

        try
        {
            if (ModelState.IsValid)
            {
                createEvaluationResponse = await _evaluationManager.CreateDancerEvaluations(createEvaluationsRequest);
            }
            else
            {

            }
        }
        catch (Exception ex)
        {

        }
        finally
        {

        }
        
        return StatusCode(StatusCodes.Status200OK, createEvaluationResponse);
    }
}

