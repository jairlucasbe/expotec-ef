using expotec_ef.Modules.BusinessExecutives.Models;
using expotec_ef.Modules.BusinessExecutives.Models.Dtos;
using expotec_ef.Modules.BusinessExecutives.Services;
using Microsoft.AspNetCore.Mvc;

namespace expotec_ef.Modules.BusinessExecutives.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessExecutivesController : ControllerBase
    {
        private readonly IBusinessExecutiveService _businessExecutiveService;

        public BusinessExecutivesController(IBusinessExecutiveService businessExecutiveService)
        {
            _businessExecutiveService = businessExecutiveService;
        }

        // GET: api/BusinessExecutives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessExecutive>>> GetAllAsync()
        {
            var businessExecutives = await _businessExecutiveService.GetAllAsync();
            return Ok(businessExecutives);
        }

        // GET: api/BusinessExecutives/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessExecutive>> GetByIdAsync(string id)
        {
            try
            {
                var businessExecutive = await _businessExecutiveService.GetByIdAsync(id);
                return Ok(businessExecutive);
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { message = "Business Executive not found." });
            }
        }

        // POST: api/BusinessExecutives
        [HttpPost]
        public async Task<ActionResult<BusinessExecutive>> CreateAsync(CreateBusinessExecutiveDto dto)
        {
            var businessExecutive = await _businessExecutiveService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = businessExecutive.Id }, businessExecutive);
        }

        // PUT: api/BusinessExecutives/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<BusinessExecutive>> UpdateAsync(string id, UpdateBusinessExecutiveDto dto)
        {
            try
            {
                var businessExecutive = await _businessExecutiveService.UpdateAsync(id, dto);
                return Ok(businessExecutive);
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { message = "Business Executive not found." });
            }
        }

        // DELETE: api/BusinessExecutives/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            try
            {
                var businessExecutive = await _businessExecutiveService.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { message = "Business Executive not found." });
            }
        }
    }
}
