using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<StudentDto, Student>()
                .ForMember(c => c.StudentPayments, option => option.Ignore());
            CreateMap<StudentPaymentDto, StudentPayment>()
              .ForMember(c => c.Student, option => option.Ignore());
        }
    }
}
