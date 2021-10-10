using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aiko.GestEquipamento.PresentationRazor.Controllers
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
        public ActionResult<EquipmentStateDTO> InsertEquipment(CreateEquipmentStateDTO dto)
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

        #region - GET
        // GET /equipmentstates
        [HttpGet]
        public async Task<IEnumerable<EquipmentState>> GetEquipmentsAsync()
        {
            var result = (await _equipmentStateService.GetAll());

            return result;

        }

        #endregion


    }
}
