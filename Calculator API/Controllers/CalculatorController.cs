using AutoMapper;
using Calculator_API.DTOs;
using Calculator_API.Model;
using Calculator_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(IMapper mapper, ICalculatorService calculatorService)
        {
            this._mapper = mapper;
            this._calculatorService = calculatorService;
        }

        /// <summary>
        /// saves a calculation
        /// </summary>
        /// <param name="calculatorDto">calculation input object</param>
        /// <returns></returns>
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody] CalculatorDto calculatorDto)
        {
            if (calculatorDto == null)
                return BadRequest(ModelState);

            var calculator = _mapper.Map<Calculator>(calculatorDto);

            if (!await _calculatorService.Create(calculator))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record");
                return StatusCode(StatusCodes.Status500InternalServerError, ModelState);
            }
            return Ok();
        }
    }
}
