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

                var addMap = config.CreateMap<AddContact, Contact>();
                addMap.ForAllMembers(opt => opt.Ignore());
                addMap.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName));
                addMap.ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName));
                addMap.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
                addMap.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
                addMap.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));
                addMap.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
                addMap.ForMember(dest => dest.CreatorRID, opt => opt.MapFrom(src => src.CreatorRID));


            });
        }
    }
}
