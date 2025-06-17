using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmploymentHistoryController : ControllerBase
    {
        private readonly IEmploymentHistoryService _employmentHistoryService;

        public EmploymentHistoryController(IEmploymentHistoryService employmentHistoryService)
        {
            _employmentHistoryService = employmentHistoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _employmentHistoryService.GetList();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _employmentHistoryService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] EmploymentHistoryDto dto)
        {
            var result = _employmentHistoryService.Add(dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id, [FromBody] EmploymentHistoryDto dto)
        {
            var result = _employmentHistoryService.Update(id, dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _employmentHistoryService.Delete(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }

}
