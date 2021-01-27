using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using QPcBackend.Entities;
using QPcBackend.Helpers;
using QPcBackend.Models.Accounts;

public interface IPartsService
{  
    List<PCPart> getAllParts();
}

public class PartsService : IPartsService{

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PartsService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PCPart> getAllParts(){
            return _context.PCPart.ToList();
        }

        

}