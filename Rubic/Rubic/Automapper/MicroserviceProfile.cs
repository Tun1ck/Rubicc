using AutoMapper;
using Rubic.Models;
using Rubic.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Automapper
{
    public class MicroserviceProfile: Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<User, UserInformationDto>()
                .ForMember(x => x.Id, x => x.MapFrom(m => m.Id))
                .ForMember(x => x.PhoneNumberPrefix, x => x.MapFrom(m => m.PhoneNumberPrefix))
                .ForMember(x => x.PhoneNumber, x => x.MapFrom(m => m.PhoneNumber))
                .ForMember(x => x.Name, x => x.MapFrom(m => m.Name))
                .ForMember(x => x.Surname, x => x.MapFrom(m => m.Surname));





        }
    }
}
