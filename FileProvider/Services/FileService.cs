using Data.Contexts;
using FileProvider.Functions;
using Microsoft.Extensions.Logging;
namespace FileProvider.Services;

public class FileService(DataContext context, ILogger<FileService> logger)
{
    private readonly ILogger<FileService> _logger = logger;
    private readonly DataContext _context = context;

}
