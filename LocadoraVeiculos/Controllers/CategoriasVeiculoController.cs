using LocadoraVeiculos.Data;
using LocadoraVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVeiculos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasVeiculoController : ControllerBase
    {
        private readonly LocadoraContext _context;

        public CategoriasVeiculoController(LocadoraContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaVeiculo>>> Get()
        {
            return await _context.CategoriasVeiculo.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaVeiculo>> Get(int id)
        {
            var categoria = await _context.CategoriasVeiculo.FindAsync(id);

            if (categoria == null)
                return NotFound();

            return categoria;
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaVeiculo>> Post(CategoriaVeiculo categoria)
        {
            _context.CategoriasVeiculo.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = categoria.IdCategoriaVeiculo }, categoria);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CategoriaVeiculo categoria)
        {
            if (id != categoria.IdCategoriaVeiculo)
                return BadRequest();

            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var categoria = await _context.CategoriasVeiculo.FindAsync(id);

            if (categoria == null)
                return NotFound();

            _context.CategoriasVeiculo.Remove(categoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}