using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApplication.Entity;
using ShopApplication.Models;

namespace ShopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTransfersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductTransfersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductTransfers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTransfer>>> GetProductTransfer()
        {
          if (_context.ProductTransfer == null)
          {
              return NotFound();
          }
            return await _context.ProductTransfer.ToListAsync();
        }

        // GET: api/ProductTransfers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductTransfer>> GetProductTransfer(Guid id)
        {
          if (_context.ProductTransfer == null)
          {
              return NotFound();
          }
            var productTransfer = await _context.ProductTransfer.FindAsync(id);

            if (productTransfer == null)
            {
                return NotFound();
            }

            return productTransfer;
        }

        // PUT: api/ProductTransfers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductTransfer(Guid id, ProductTransfer productTransfer)
        {
            if (id != productTransfer.Id)
            {
                return BadRequest();
            }

            _context.Entry(productTransfer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTransferExists(id))
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

        // POST: api/ProductTransfers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductTransfer>> PostProductTransfer(ProductTransfer productTransfer)
        {
          if (_context.ProductTransfer == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ProductTransfer'  is null.");
          }
            _context.ProductTransfer.Add(productTransfer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTransfer", new { id = productTransfer.Id }, productTransfer);
        }

        // DELETE: api/ProductTransfers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductTransfer(Guid id)
        {
            if (_context.ProductTransfer == null)
            {
                return NotFound();
            }
            var productTransfer = await _context.ProductTransfer.FindAsync(id);
            if (productTransfer == null)
            {
                return NotFound();
            }

            _context.ProductTransfer.Remove(productTransfer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductTransferExists(Guid id)
        {
            return (_context.ProductTransfer?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
