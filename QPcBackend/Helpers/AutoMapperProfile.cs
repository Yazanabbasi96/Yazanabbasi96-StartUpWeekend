using AutoMapper;
using QPcBackend.Entities;
using QPcBackend.Models.Accounts;
using System;


namespace pushUpBackend.Helpers
{
    public class AutoMapperProfile : Profile
    {
        // mappings between model and entity objects
        public AutoMapperProfile()
        {
            CreateMap<Account, AccountLoginResponse>();
        }
    }
}