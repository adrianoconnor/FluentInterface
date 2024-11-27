using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EntityInterface.Core.Controllers;

public class DynamicCrudPagesController : Controller
{
    public DynamicCrudPagesController(ILoggerFactory loggerFactory, EntityInterfaceOptions options)
    {
        var logger = loggerFactory.CreateLogger<DynamicCrudPagesController>();
        logger.LogInformation("Creating DynamicCrudPagesController");
        logger.LogInformation(options.ToString());
    }
    
    [HttpGet]
    public IActionResult Index(string entity)
    {
        IEnumerable<dynamic> data = new List<dynamic>();
        
        return View(new
        {
            entity,
            data
        });
    }

    [HttpGet]
    public IActionResult Show(string? id, string entity)
    {
        return new OkObjectResult($"Show {entity} {id}...");
    }
}