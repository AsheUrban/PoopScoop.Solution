using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<ActionResult<IEnumerable<Poop>>> Get()
    {
      return await _db.Poops.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Poop>> Post(Poop poop)
    {
      _db.Poops.Add(poop);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = poop.PoopId }, poop);
    }
  }
}