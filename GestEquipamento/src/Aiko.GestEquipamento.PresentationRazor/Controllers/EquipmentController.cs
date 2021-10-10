using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aiko.GestEquipamento.PresentationRazor.Controllers
{
    [ApiController]
    [Route("equipments")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        //#region - GET
        //// GET /equipments
        //[HttpGet]
        //public async Task<IEnumerable<EquipmentDTO>>  GetEquipments()
        //{
        //    var result = await _equipmentService.GetAll();

        //    return result.Select(e => e.AsEquipmentDTO());
        //}

        //// GET /equipments/{id}
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Equipment>> GetEquipment(Guid id)
        //{
        //    return await _equipmentService.Get(id);
        //}
        //#endregion


        #region - POST
        // POST /equipments
        [HttpPost]
        public ActionResult<Equipment> InsertEquipment(CreateEquipmentDTO dto)
        {
            try
            {
                _equipmentService.Insert(dto);
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