using ECom.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class GenericController<T> : ControllerBase where T : class
    {
        protected readonly IGenericService<T> _service;
        protected GenericController(IGenericService<T> service) => _service = service;

        [HttpGet]
        public virtual async Task<IActionResult> GetAll() => Ok(await _service.ListAsync());

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(object id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] T dto)
        {
            await _service.AddAsync(dto);
            return Created("", dto);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] object id, [FromBody] T dto)
        {
            await _service.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(object id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}