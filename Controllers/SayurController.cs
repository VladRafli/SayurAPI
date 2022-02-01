using SayurAPI.Models;
using SayurAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace SayurAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SayurContoller : ControllerBase
{

    // GET all action
    [HttpGet]
    public ActionResult<List<Sayur>> GetAll() =>
        SayurService.GetAll();
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Sayur> Get(int id)
    {
        var sayur = SayurService.Get(id);
        if (sayur == null)
            return NotFound();
        return sayur;
    }
    // POST action
    [HttpPost]
    public IActionResult Create(Sayur sayur)
    {
        // This code will save the sayur and return a result
        SayurService.Add(sayur);
        return CreatedAtAction(nameof(Create), new { id = sayur.Id }, sayur);
    }
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Sayur sayur)
    {
        // This code will update the pizza and return a result
        if (id != sayur.Id)
            return BadRequest();
        var existingSayur = SayurService.Get(id);
        if (existingSayur is null)
            return NotFound();
        SayurService.Update(sayur);
        return NoContent();
    }
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // This code will delete the pizza and return a result
        var sayur = SayurService.Get(id);
        if (sayur is null)
            return NotFound();
        SayurService.Delete(id);
        return NoContent();
    }
}