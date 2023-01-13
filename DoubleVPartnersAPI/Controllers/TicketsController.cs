using DoubleVPartnersAPI.Data;
using DoubleVPartnersAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoubleVPartnersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly DoubleVPartnersContext _context;


        public TicketsController(DoubleVPartnersContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetDetalleEspecificoOPxidOP/{pageNumber:int}/{pageSize:int}")]
        public async Task<ActionResult<IEnumerable<TKS_TICKETS>>> GetTicketItems(int pageNumber, int pageSize)
        {
            return await _context.TKS_TICKETS.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<TKS_TICKETS>> GetTicketItem(long id)
        {
            var TicketItem = await _context.TKS_TICKETS.FindAsync(id);

            if (TicketItem == null)
            {
                return NotFound();
            }
            return TicketItem;
        }

        [HttpPost]
        public async Task<ActionResult<TKS_TICKETS>> AddTicketItem(TKS_TICKETS item)
        {
            try
            {
                item.FECHA_CREACION = DateTime.UtcNow.Date;
                _context.TKS_TICKETS.Add(item);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetTicketItem), new { id = item.Id }, item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateTicketItem(long id, TKS_TICKETS item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var actualizarTicket = _context.TKS_TICKETS.Where(t => t.Id == id).SingleOrDefault();
            actualizarTicket.ESTADO = item.ESTADO;
            actualizarTicket.USUARIO = item.USUARIO;
            actualizarTicket.FECHA_ACTUALIZACION = DateTime.UtcNow.Date;
            await _context.SaveChangesAsync();

            return Ok(actualizarTicket);
        }
    }
}
