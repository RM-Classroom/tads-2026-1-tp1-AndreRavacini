using LocadoraVeiculos.Data;
using LocadoraVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVeiculos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly LocadoraContext _context;

        public VeiculosController(LocadoraContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> Get()
        {
            return await _context.Veiculos.ToListAsync();
        }

        [HttpGet("fabricante/{idFabricante}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetPorFabricante(int idFabricante)
        {
            return await _context.Veiculos
                .Include(v => v.Fabricante)
                .Include(v => v.CategoriaVeiculo)
                .Where(v => v.IdFabricante == idFabricante)
                .ToListAsync();
        }

        [HttpGet("categoria/{idCategoria}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetPorCategoria(int idCategoria)
        {
            return await _context.Veiculos
                .Include(v => v.Fabricante)
                .Include(v => v.CategoriaVeiculo)
                .Where(v => v.IdCategoriaVeiculo == idCategoria)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculo>> Get(int id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo == null)
                return NotFound();

            return veiculo;
        }

        [HttpPost]
        public async Task<ActionResult<Veiculo>> Post(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = veiculo.IdVeiculo }, veiculo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Veiculo veiculo)
        {
            if (id != veiculo.IdVeiculo)
                return BadRequest();

            _context.Entry(veiculo).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo == null)
                return NotFound();

            _context.Veiculos.Remove(veiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}