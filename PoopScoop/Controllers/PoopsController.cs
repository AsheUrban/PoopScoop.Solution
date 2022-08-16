using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using PoopScoop.Models;

namespace PoopScoop.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PoopsController : ControllerBase
  {
    private readonly PoopScoopContext _db;

    public PoopsController(PoopScoopContext db)
    {
      _db = db;
		}

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Poop>>> Get(string consistency, string volume, string color, string content, string coating, string grade, string problem, string solution)
    {
      var query = _db.Poops.AsQueryable();
      if (consistency != null )
      {
        query = query.Where(entry => entry.Consistency == consistency);
      }
      if (volume != null )
      {
        query = query.Where(entry => entry.Volume == volume);
      }
      if (color != null )
      {
        query = query.Where(entry => entry.Color == color);
      }
      if (content != null )
      {
        query = query.Where(entry => entry.Content == content);
      }
      if (coating != null )
      {
        query = query.Where(entry => entry.Coating == coating);
      }
      if (grade != null )
      {
        query = query.Where(entry => entry.Grade == grade);
      }
      if (problem != null )
      {
        query = query.Where(entry => entry.Problem == problem);
      }
      if (solution != null )
      {
        query = query.Where(entry => entry.Solution == solution);
      }
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Poop>> Post(Poop poop)
    {
      _db.Poops.Add(poop);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = poop.PoopId }, poop);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Poop>> GetPoop(int id)
    {
      var poop = await _db.Poops.FindAsync(id);
      
      if (poop == null)
      {
        return NotFound();
      }
      return poop;
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Poop poop)
    {
      if (id != poop.PoopId)
      {
        return BadRequest();
      }
      
      _db.Entry(poop).State = EntityState.Modified;
      
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PoopExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
     
    private bool PoopExists(int id)
    {
      return _db.Poops.Any(e => e.PoopId == id);
		}

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePoop(int id)
    {
      var poop = await _db.Poops.FindAsync(id);
      if (poop == null)
      {
        return NotFound();
      }
      
      _db.Poops.Remove(poop);
      await _db.SaveChangesAsync();
      
      return NoContent();
    }
	}
}