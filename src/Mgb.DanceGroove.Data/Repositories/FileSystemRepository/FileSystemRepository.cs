using Mgb.DanceGroove.Core.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mgb.DanceGroove.Data.Repositories.FileSystemRepository;

public class FileSystemRepository : IFileSystemRepository
{
    private readonly ILogger<FileSystemRepository> _logger;

    public FileSystemRepository(ILogger<FileSystemRepository> logger)
    {
        _logger = logger;
    }
}
