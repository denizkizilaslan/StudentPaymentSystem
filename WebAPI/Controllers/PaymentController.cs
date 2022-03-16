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
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("GetStudentPayments")]
        public IActionResult GetStudentPayments(StudentDateRangeDto model)
        {
            return Ok(_paymentService.GetStudentPayments(model));
        }

        //[HttpPost("AddStudentPayment")]
        //public IActionResult AddStudent(StudentPaymentDto paymentDto)
        //{
        //    StudentPayment model = _mapper.Map<StudentPayment>(paymentDto);
        //    var result = _paymentService.Add(model);
        //    if (result.Status)
        //        return Ok(result);
        //    else
        //        return BadRequest(result);
        //}

    }
}
