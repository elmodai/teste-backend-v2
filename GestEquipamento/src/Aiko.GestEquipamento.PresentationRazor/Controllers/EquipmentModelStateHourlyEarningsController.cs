using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aiko.GestEquipamento.PresentationRazor.Controllers
{
    [ApiController]
    [Route("equipmentsearnings")]    
    public class EquipmentModelStateHourlyEarningsController : ControllerBase
    {
        private readonly IEquipmentModelStateHourlyEarningsService _equipmentModelStateHourlyEarningsService;

        public EquipmentModelStateHourlyEarningsController(IEquipmentModelStateHourlyEarningsService
            equipmentModelStateHourlyEarningsService)
        {
            _equipmentModelStateHourlyEarningsService = equipmentModelStateHourlyEarningsService;
        }

        #region - POST
        // POST /equipmentsearnings
        [HttpPost]
        public ActionResult<EquipmentModelStateHourlyEarnings> InsertEquipment(EquipmentModelStateHourlyEarningsDTO dto)
        {
            try
            {
                _equipmentModelStateHourlyEarningsService.Insert(dto);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        #endregion

    }
}