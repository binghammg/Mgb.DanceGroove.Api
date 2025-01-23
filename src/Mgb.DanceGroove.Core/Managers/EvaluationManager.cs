using Mgb.DanceGroove.Core.Models.Requests;
using Mgb.DanceGroove.Core.Models.Responses;
using Mgb.DanceGroove.Core.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mgb.DanceGroove.Core.Managers;

public class EvaluationManager : IEvaluationManager
{
    private readonly IFileSystemRepository _fileSystemRepository;
    private readonly ILogger<EvaluationManager> _logger;

    public EvaluationManager(
        IFileSystemRepository fileSystemRepository,
        ILogger<EvaluationManager> logger)
    {
        _fileSystemRepository = fileSystemRepository ?? throw new ArgumentNullException(nameof(fileSystemRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<CreateEvaluationsResponse> CreateDancerEvaluations(CreateEvaluationsRequest createEvaluationRequest)
    {
        var createEvaluationResponse = new CreateEvaluationsResponse();

        try
        {
            //var evaluationsFile = _fileSystemRepository.GetEvaluationsFile(createEvaluationRequest.SourcePath);

            //foreach (var fileToCreate in filesToCreate)
            //{
            //    Create File
            //}
        }
        catch (Exception ex)
        {

        }
        finally
        {

        }

        return createEvaluationResponse;
    }
}
