using Data.Contexts;
using FileProvider.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FileProvider.Functions
{
    public class Upload(ILogger<Upload> logger, FileService fileService)
    {
        private readonly ILogger<Upload> _logger = logger;
        private readonly FileService _fileService = fileService;

        [Function("Upload")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {

        }
    }
}