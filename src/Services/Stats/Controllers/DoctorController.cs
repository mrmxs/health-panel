using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthPanel.Core.Entities;
using HealthPanel.Infrastructure.Data;
using HealthPanel.Services.Stats.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthPanel.Services.Stats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController
        : AbstractController<Doctor, DoctorDto>
    {
        public DoctorController(HealthPanelDbContext context) : base(context) { }

        // GET: api/Doctor
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<DoctorDto>>> Get()
        {
            var entities = await _context.Doctors.ToListAsync();

            var dtos = entities
                .Select(async p => await this.EntityToDtoAsync(p))
                .Select(t => t.Result)
                .Where(i => i != null)
                .ToList();

            return Ok(dtos);
        }

        // GET: api/Doctor/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<DoctorDto>> Get(int id)
        {
            var entity = await _context.Doctors.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(await this.EntityToDtoAsync(entity));
        }

        // PUT: api/Doctor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> Put(int id, DoctorDto dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }


            var modified = await _context.Doctors.FindAsync(id);

            modified.Name = dto.Name; //todo bad practice
            modified.HealthFacilityBranchId = dto.HealthFacilityBranchId;
            _context.Entry(modified).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(id))
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

        // POST: api/Doctor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<DoctorDto>> Post(DoctorDto dto)
        {
            _context.Doctors.Add(this.ConvertToEntity(dto));

            var newEntityId = await _context.SaveChangesAsync();
            var newEntity = await _context.Doctors.FindAsync(newEntityId);

            return CreatedAtAction(nameof(Post),
                 new { id = newEntity.Id },
                 await this.EntityToDtoAsync(newEntity));
        }

        // DELETE: api/Doctor/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> Delete(int id)
        {
            var entity = await _context.Doctors.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        protected override bool Exists(int id)
            => _context.Doctors.Any(e => e.Id == id);

        protected override async Task<DoctorDto> EntityToDtoAsync(Doctor entity)
            => new DoctorDto(entity);

        private Doctor ConvertToEntity(DoctorDto dto)
            => new()
            {
                // Id = dto.Id,
                Name = dto.Name,
                HealthFacilityBranchId = dto.HealthFacilityBranchId,
            };
    }
}
