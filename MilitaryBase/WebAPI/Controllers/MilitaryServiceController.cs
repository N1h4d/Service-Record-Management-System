using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MilitaryServiceController : ControllerBase
    {
        private readonly IMilitaryServiceService _militaryServiceService;

        public MilitaryServiceController(IMilitaryServiceService militaryServiceService)
        {
            _militaryServiceService = militaryServiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _militaryServiceService.GetList();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _militaryServiceService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] MilitaryServiceDto dto)
        {
            var result = _militaryServiceService.Add(dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id, [FromBody] MilitaryServiceDto dto)
        {
            var result = _militaryServiceService.Update(id, dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _militaryServiceService.Delete(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }

}
