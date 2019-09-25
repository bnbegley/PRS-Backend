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
    public class RequestsAPIController : ControllerBase
    {
        private readonly MyDb _context;

        public RequestsAPIController(MyDb context)
        {
            _context = context;
        }


        // Set request to APPROVED
        [HttpGet("/api/setApproved/{id}")]
        public async Task<IActionResult> PutRequestApproved(int id)
        {

            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            #region Set Request.Status to APPROVED
            request.Status = "APPROVED";
            #endregion

            await _context.SaveChangesAsync();

            return NoContent();
        }


        // GET: api/RequestsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequests()
        {
            return await _context.Requests.ToListAsync();
        }

        // GET: api/GetRequestsForReview
        [Route("/api/GetRequestsForReview")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequestsForReview()
        {
            return await _context //the databases
                .Requests //the entity
                .Where(r => r.Status == "Review") //filter for review
                .ToListAsync(); //return a collection

            //var items = from r in _context.Request
            //            where r.Status == "Review"
            //            select r;
            //return items.ToListAsync();
        }

        // GET: api/RequestsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            return request;
        }


/*
        [HttpPut("/api/Requests/Review/{id}")]
        public async Task<IActionResult> PutRequestReview(int id)
        {

            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }
            #region If statement using Request.Total
            if (request.Total <= 50)
            {
                request.Status = "APPROVED";
            }
            else
            {
                request.Status = "REVIEW";
            }
            #endregion
            await _context.SaveChangesAsync();
            // body code goes here
            return NoContent();
        }*/

        // PUT: api/RequestsAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(id))
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


        // Set request to REJECTED
        [HttpGet("/api/setRejected/{id}")]
        public async Task<IActionResult> PutRequestRejected(int id)
        {

            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            #region Set Request.Status to REJECTED
            request.Status = "REJECTED";
            #endregion

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Set request to REVIEW or APPROVED based on Total <= 50
        [HttpGet("/api/setReview/{id}")]
        public async Task<IActionResult> PutRequestReview(int id)
        {

            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }
            #region If statement using Request.Total
            if (request.Total <= 50)
            {
                request.Status = "APPROVED";
            }
            else
            {
                request.Status = "REVIEW";
            }
            #endregion
            await _context.SaveChangesAsync();
            // body code goes here
            return NoContent();
        }


        // POST: api/RequestsAPI
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
            _context.Requests.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/RequestsAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Request>> DeleteRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return request;
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.Id == id);
        }
    }
}
