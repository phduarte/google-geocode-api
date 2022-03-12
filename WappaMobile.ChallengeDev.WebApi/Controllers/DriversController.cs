using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WappaMobile.ChallengeDev.Models;
using WappaMobile.ChallengeDev.Models.Drivers;

namespace WappaMobile.ChallengeDev.WebApi.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly GetAllDriversUseCase _getAllDriversUseCase;
        private readonly CreateDriverUseCase _createDriverUseCase;
        private readonly UpdateDriverUseCase _updateDriverUseCase;
        private readonly DeleteDriverUseCase _deleteDriverUseCase;
        private readonly GetDriverByIdUseCase _getDriverByIdUseCase;

        public DriversController(GetAllDriversUseCase getAllDriversUseCase,
            CreateDriverUseCase createDriverUseCase,
            UpdateDriverUseCase updateDriverUseCase,
            DeleteDriverUseCase deleteDriverUseCase,
            GetDriverByIdUseCase getDriverByIdUseCase)
        {
            _getAllDriversUseCase = getAllDriversUseCase;
            _createDriverUseCase = createDriverUseCase;
            _updateDriverUseCase = updateDriverUseCase;
            _deleteDriverUseCase = deleteDriverUseCase;
            _getDriverByIdUseCase = getDriverByIdUseCase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Driver>> Get([FromQuery] string orderby = "", string name = "")
        {
            try
            {
                var model = _getAllDriversUseCase.Execute(new DriverSearchCriteria
                {
                    Name = name,
                    OrderBy = orderby,
                });

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<DriverSummary> Get(Guid id)
        {
            try
            {
                var driver = _getDriverByIdUseCase.Execute(IdentityRequestResponse.From(id));
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
                var id = _createDriverUseCase.Execute(driver);

                return Created(Url.Action("Get"), id);
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
                _updateDriverUseCase.Execute(DriverUpdateInfo.From(value));
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
                _deleteDriverUseCase.Execute(IdentityRequestResponse.From(id));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
