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
    public class FamilyInformationController : ControllerBase
    {
        private readonly IFamilyInformationService _familyInformationService;

        public FamilyInformationController(IFamilyInformationService familyInformationService)
        {
            _familyInformationService = familyInformationService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _familyInformationService.GetList();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _familyInformationService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] FamilyInformationDto dto)
        {
            var result = _familyInformationService.Add(dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id, [FromBody] FamilyInformationDto dto)
        {
            var result = _familyInformationService.Update(id, dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _familyInformationService.Delete(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }

}
