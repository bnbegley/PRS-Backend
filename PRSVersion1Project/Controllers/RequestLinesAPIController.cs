using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRSVersion1Project.Models;

namespace PRSVersion1Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestLinesAPIController : ControllerBase
    {
        private readonly MyDb _context;

        public RequestLinesAPIController(MyDb context)
        {
            _context = context;
        }

        // GET: api/RequestLinesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestLine>>> GetRequestLines()
        {
            return await _context.RequestLines.ToListAsync();
        }

        // GET: api/RequestLinesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestLine>> GetRequestLine(int id)
        {
            var requestLine = await _context.RequestLines.FindAsync(id);

            if (requestLine == null)
            {
                return NotFound();
            }

            return requestLine;
        }

        // PUT: api/RequestLinesAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestLine(int id, RequestLine requestLine)
        {
            if (id != requestLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(requestLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                //call recalculate?
                var success = RecalculateRequestTotal(requestLine.RequestId);
                if (!success) { return this.StatusCode(500); }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestLineExists(id))
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

        // POST: api/RequestLinesAPI
        [HttpPost]
        public async Task<ActionResult<RequestLine>> PostRequestLine(RequestLine requestLine)
        {
            _context.RequestLines.Add(requestLine);
            await _context.SaveChangesAsync();

            if (!RecalculateRequestTotal(requestLine.RequestId))
            {

            }

            return CreatedAtAction("GetRequestLine", new { id = requestLine.Id }, requestLine);
        }
        // DELETE: api/RequestLinesAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RequestLine>> DeleteRequestLine(int id)
        {
            var requestLine = await _context.RequestLines.FindAsync(id);
            if (requestLine == null)
            {
                return NotFound();
            }

            _context.RequestLines.Remove(requestLine);
            await _context.SaveChangesAsync();
            ///call recalc
            var success = RecalculateRequestTotal(requestLine.RequestId);
            if (!success) { return this.StatusCode(500); }
            return requestLine;
        }


        private bool RequestLineExists(int id)
        {
            return _context.RequestLines.Any(e => e.Id == id);
        }

        private bool RecalculateRequestTotal(int requestId)
        {
            var request = _context.Requests.
                SingleOrDefault(r => r.Id == requestId);
            if (request == null)
            {
                return false;
            }
            request.Total = _context.RequestLines
                .Include(l => l.Product)
                .Where(l => l.RequestId == requestId)
                .Sum(l => l.Quantity * l.Product.Price);

            _context.SaveChanges();
            return true;

        }
    }
}
