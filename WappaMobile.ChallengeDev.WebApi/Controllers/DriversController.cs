using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.WebApi.Controllers
{
    [Route("api/public/v1/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly DriverServices _driverServices;

        public DriversController(DriverServices driverServices)
        {
            _driverServices = driverServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Driver>> Get([FromQuery]string orderby = "")
        {
            try
            {
                var model = _driverServices.GetDrivers();

                if (orderby.ToLower().Equals("fistname"))
                    return Ok(model.OrderBy(x => x.Name.FirstName));

                if (orderby.ToLower().Equals("lastname"))
                    return Ok(model.OrderBy(x => x.Name.LastName));

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Driver> Get(Guid id)
        {
            try
            {
                var driver = _driverServices.GetById(id);
                return Ok(driver);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Driver driver)
        {
            if (!driver.IsValid)
                return BadRequest("It is not a valid driver.");

            try
            {
                _driverServices.Add(driver);

                return Created(Url.Action("Get"),driver.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Driver value)
        {
            value.Id = id;

            try
            {
                _driverServices.Save(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _driverServices.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
