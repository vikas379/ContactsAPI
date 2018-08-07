using AutoMapper;
using ContactsAPI.Application.Contract.Contracts;
using ContactsAPI.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<Contact, Contacts>();

                config.CreateMap<AddContact, Contact>()
                    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.CreatorRID, opt => opt.MapFrom(src => src.CreatorRID))
                    .ForAllOtherMembers(opt => opt.Ignore());



            });
        }
    }
}
