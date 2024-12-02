using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseRegisterDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseRegistersController(IGenericService<CourseRegister> _courseRegisterService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetMyCourses/{userId}")]
        public IActionResult GetMyCourses(int userId)
        {
            var values = _courseRegisterService.TGetFilteredList(x=>x.AppUserId == userId);
            var mappedValues = _mapper.Map<List<ResultCourseRegisterDto>>(values);
            return Ok(mappedValues);
        }

        [HttpPost]
        public IActionResult RegisterToCourse(CreateCourseRegisterDto model)
        {
            var newCourseRegister = _mapper.Map<CourseRegister>(model);
            _courseRegisterService.TCreate(newCourseRegister);
            return Ok("Kursa Kayıt Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateCourseRegister(UpdateCourseRegisterDto model)
        {
            var updateModel = _mapper.Map<CourseRegister>(model);
            _courseRegisterService.TUpdate(updateModel);
            return Ok("Kurs Kaydı Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseRegisterService.TGetById(id);
            var mappedValue = _mapper.Map<ResultCourseRegisterDto>(value);
            return Ok(mappedValue);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourseRegister(int id)
        {
            _courseRegisterService.TDelete(id);
            return Ok("Kurs Kaydı Silindi");
        }
    }
}
