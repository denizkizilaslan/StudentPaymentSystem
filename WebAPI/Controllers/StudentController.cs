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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        /// <summary>
        /// Öğrencilerin özelliklerini listeleyecek.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetStudentList")]
        public IActionResult GetStudentList()
        {
            return Ok(_studentService.GetStudentList());
        }

        /// <summary>
        /// Özel bir öğrenciye ulaşmak istediğimizde bunun bilgilerini getirecek.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            return Ok(_studentService.GetStudent(id));
        }

        /// <summary>
        /// Öğrencilerin ödemelerini listeleyecek
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetStudentsWithPayments")]
        public IActionResult GetStudentsWithPayments()
        {
            return Ok(_studentService.GetStudentsWithPayments());
        }

        /// <summary>
        /// Yeni bir öğrenci kaydedebilecek
        /// </summary>
        /// <param name="studentDto"></param>
        /// <returns></returns>
        [HttpPost("AddStudent")]
        public IActionResult AddStudent(StudentDto studentDto)
        {
            Student model = _mapper.Map<Student>(studentDto);
            var result = _studentService.Add(model);
            if (result.Status)
                return Ok(result);
            else
                return BadRequest(result);
        }

        /// <summary>
        /// Mevcut Öğrenciyi değiştirebilecek
        /// </summary>
        /// <param name="studentDto"></param>
        /// <returns></returns>
        [HttpPost("UpdateStudent")]
        public IActionResult UpdateStudent(StudentDto studentDto)
        {
            Student model = _mapper.Map<Student>(studentDto);
            var result = _studentService.Update(model);
            if (result.Status)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
