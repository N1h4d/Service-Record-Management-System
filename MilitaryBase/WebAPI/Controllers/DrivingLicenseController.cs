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
    public class DrivingLicenseController : ControllerBase
    {
        private readonly IDrivingLicenseService _drivingLicenseService;

        public DrivingLicenseController(IDrivingLicenseService drivingLicenseService)
        {
            _drivingLicenseService = drivingLicenseService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _drivingLicenseService.GetList();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _drivingLicenseService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] DrivingLicenseDto dto)
        {
            var result = _drivingLicenseService.Add(dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id, [FromBody] DrivingLicenseDto dto)
        {
            var result = _drivingLicenseService.Update(id, dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _drivingLicenseService.Delete(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }

}
