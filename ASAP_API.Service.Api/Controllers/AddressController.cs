using ASAP_API.Application.Interfaces;
using ASAP_API.Application.ViewModels.Address;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASAP_API.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAdressAppServices _adressAppServices;

        public AddressController(IAdressAppServices adressAppServices)
        {
            _adressAppServices = adressAppServices;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult Get()
        {
            return Ok(
                     _adressAppServices.GetAll());
        }

        [HttpGet()]
        [Route("Get/{Id}")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(new { Data = _adressAppServices.GetById(Id), success = true });
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] AdressSaveViewModel model)
        {

            if (_adressAppServices.Create(model))
                return Ok(new { Data = model, success = true });
            return BadRequest(new { Data = model, success = false });
        }

        [HttpPut]
        [Route("Edite")]
        public IActionResult Edite(AdressViewModel model)
        {

            if (_adressAppServices.Update(model))
                return Ok(new { Data = model, success = true });
            return BadRequest(new { Data = model, success = false });
        }

        [HttpDelete]
        [Route("Delete/{Id}")]
        public IActionResult Delete(Guid Id)
        {

            if (_adressAppServices.Remove(Id))
                return Ok(new { Data = Id, success = true });
            return BadRequest(new { Data = Id, success = false });
        }

    }
}
