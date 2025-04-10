using Microsoft.AspNetCore.Mvc;
using TesteDS.API.Application;
using TesteDS.Domain.Models;

namespace TesteDS.API.Presentation;

[ApiController]
[Route("[controller]")]
public class WorkerController : ControllerBase
{
    private readonly WorkerService _workerService;

    public WorkerController(WorkerService workerService)
    {
        _workerService = workerService;
    }

    [HttpGet(WorkerRoutesApi.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var obj = await _workerService.GetAll();
        return Ok(obj);
    }
}
