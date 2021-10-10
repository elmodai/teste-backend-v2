using System;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aiko.GestEquipamento.PresentationAPI.Controllers
{
    [ApiController]
    [Route("equipmentstates")]
    public class EquipmentStateController : ControllerBase
    {
        private readonly IEquipmentStateService _equipmentStateService;

        public EquipmentStateController(IEquipmentStateService equipmentStateService)
        {
            _equipmentStateService = equipmentStateService;
        }

        #region - POST
        // POST /equipmentstates
        [HttpPost]
        public ActionResult<EquipmentState> InsertEquipment(CreateEquipmentStateDTO dto)
        {
            try
            {
                _equipmentStateService.Insert(dto);
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
