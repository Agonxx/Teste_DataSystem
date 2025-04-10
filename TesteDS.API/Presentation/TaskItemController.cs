using Domain.Dtos;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using TesteDS.API.Application;

namespace TesteDS.API.Presentation;

[ApiController]
[Route("[controller]")]
public class TaskItemController : ControllerBase
{
    private readonly TaskItemService _taskItemService;

    public TaskItemController(TaskItemService taskItemService)
    {
        _taskItemService = taskItemService;
    }

    [HttpPost(TaskItemRoutesApi.Create)]
    public async Task<IActionResult> Create([FromBody] TaskItemDto taskItemObj)
    {
        var obj = await _taskItemService.Create(taskItemObj);
        return Ok(obj);
    }

    [HttpGet(TaskItemRoutesApi.GetById)]
    public async Task<IActionResult> GetById([FromQuery] int taskId)
    {
        var obj = await _taskItemService.GetById(taskId);
        return Ok(obj);
    }
    
    [HttpGet(TaskItemRoutesApi.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var obj = await _taskItemService.GetAll();
        return Ok(obj);
    }
    
    [HttpPut(TaskItemRoutesApi.Update)]
    public async Task<IActionResult> Update([FromBody] TaskItemDto taskItemObj)
    {
        var obj = await _taskItemService.Update(taskItemObj);
        return Ok(obj);
    }
    
    [HttpPut(TaskItemRoutesApi.UpdateStatus)]
    public async Task<IActionResult> UpdateStatus([FromBody] TaskItemDto taskItemObj)
    {
        var obj = await _taskItemService.UpdateStatus(taskItemObj);
        return Ok(obj);
    }

    [HttpDelete(TaskItemRoutesApi.DeleteById)]
    public async Task<IActionResult> DeleteById([FromQuery] int taskId)
    {
        var obj = await _taskItemService.DeleteById(taskId);
        return Ok(obj);
    }
}
