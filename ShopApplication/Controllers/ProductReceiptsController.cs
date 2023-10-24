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
    public class ProductReceiptsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductReceipts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductReceipt>>> GetProductReceipt()
        {
          if (_context.ProductReceipt == null)
          {
              return NotFound();
          }
            return await _context.ProductReceipt.ToListAsync();
        }

        // GET: api/ProductReceipts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductReceipt>> GetProductReceipt(Guid id)
        {
          if (_context.ProductReceipt == null)
          {
              return NotFound();
          }
            var productReceipt = await _context.ProductReceipt.FindAsync(id);

            if (productReceipt == null)
            {
                return NotFound();
            }

            return productReceipt;
        }

        // PUT: api/ProductReceipts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductReceipt(Guid id, ProductReceipt productReceipt)
        {
            if (id != productReceipt.Id)
            {
                return BadRequest();
            }

            _context.Entry(productReceipt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductReceiptExists(id))
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

        // POST: api/ProductReceipts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductReceipt>> PostProductReceipt(ProductReceipt productReceipt)
        {
          if (_context.ProductReceipt == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ProductReceipt'  is null.");
          }
            _context.ProductReceipt.Add(productReceipt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductReceipt", new { id = productReceipt.Id }, productReceipt);
        }

        // DELETE: api/ProductReceipts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductReceipt(Guid id)
        {
            if (_context.ProductReceipt == null)
            {
                return NotFound();
            }
            var productReceipt = await _context.ProductReceipt.FindAsync(id);
            if (productReceipt == null)
            {
                return NotFound();
            }

            _context.ProductReceipt.Remove(productReceipt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductReceiptExists(Guid id)
        {
            return (_context.ProductReceipt?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
