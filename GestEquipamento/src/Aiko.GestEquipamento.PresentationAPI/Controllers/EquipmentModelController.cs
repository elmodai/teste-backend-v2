using System;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aiko.GestEquipamento.PresentationAPI.Controllers
{
    [ApiController]
    [Route("equipmentmodels")]
    public class EquipmentModelController : ControllerBase
    {
        private readonly IEquipmentModelService _equipmentModelService;

        public EquipmentModelController(IEquipmentModelService equipmentModelService)
        {
            _equipmentModelService = equipmentModelService;
        }

        #region - POST
        // POST /equipmentmodels
        [HttpPost]
        public ActionResult<EquipmentModel> InsertEquipment(CreateEquipmentModelDTO dto)
        {
            try
            {
                _equipmentModelService.Insert(dto);

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
