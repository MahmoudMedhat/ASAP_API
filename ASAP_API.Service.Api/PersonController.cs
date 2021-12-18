using ASAP_API.Application.Interfaces;
using ASAP_API.Application.ViewModels.Person;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASAP_API.Service.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonAppServices _PersonAppServices;

        public PersonController(IPersonAppServices PersonAppServices)
        {
            _PersonAppServices = PersonAppServices;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult Get()
        {
            return Ok(
                     _PersonAppServices.GetAll());
        }

        [HttpGet()]
        [Route("Get/{Id}")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(new { Data = _PersonAppServices.GetById(Id), success = true });
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] PersonSaveViewModel model)
        {

            if (_PersonAppServices.Create(model))
                return Ok(new { Data = model, success = true });
            return BadRequest(new { Data = model, success = false });
        }

        [HttpPut]
        [Route("Edite")]
        public IActionResult Edite(UpdatePersonViewModel model)
        {

            if (_PersonAppServices.Update(model))
                return Ok(new { Data = model, success = true });
            return BadRequest(new { Data = model, success = false });
        }

        [HttpDelete]
        [Route("Delete/{Id}")]
        public IActionResult Delete(Guid Id)
        {

            if (_PersonAppServices.Remove(Id))
                return Ok(new { Data = Id, success = true });
            return BadRequest(new { Data = Id, success = false });
        }

    }
}
