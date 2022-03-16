using AutoMapper;
using Business.Abstract;
using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;
        public PaymentController(IPaymentService paymentService,IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }

        /// <summary>
        /// Öğrencilerin ödemelerini listeleyecek.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet("GetStudentsPayments")]
        public IActionResult GetStudentsPayments( )
        {
            return Ok(_paymentService.GetStudentsPayments());
        }

        /// <summary>
        /// Belirli tarihler arasında o öğrencinin ödemelerini görebilecek.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        [HttpPost("GetStudentPayments")]
        public IActionResult GetStudentPayments(StudentDateRangeDto model)
        {
            return Ok(_paymentService.GetStudentPayments(model));
        }

        /// <summary>
        /// Bir öğrenciye belirli bir miktar ödeme girebilecek
        /// </summary>
        /// <param name="paymentDto"></param>
        /// <returns></returns>
        [HttpPost("AddStudentPayment")]
        public IActionResult AddStudent(StudentPaymentDto paymentDto)
        {
            StudentPayment model = _mapper.Map<StudentPayment>(paymentDto);
            var result = _paymentService.Add(model);
            if (result.Status)
                return Ok(result);
            else
                return BadRequest(result);
        }

    }
}
