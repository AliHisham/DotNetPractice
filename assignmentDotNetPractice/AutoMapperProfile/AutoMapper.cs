using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using assignmentDotNetPractice.Entites;
using assignmentDotNetPractice.DTO;

namespace assignmentDotNetPractice.AutoMapperProfile
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductToRead>();
        }
    }
}
