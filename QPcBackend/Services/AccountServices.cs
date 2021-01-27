using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using QPcBackend.Entities;
using QPcBackend.Helpers;
using QPcBackend.Models.Accounts;

public interface IAccountServices
{  
    AccountLoginResponse loginRequest(AccountLoginRequest model);
}

public class AccountServices : IAccountServices{

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AccountServices(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AccountLoginResponse loginRequest(AccountLoginRequest model){
           var userAccount = _context.Accounts.Where(x => x.Username == model.Username && x.Password == model.Password);
           Account returnedUser = new Account();
           foreach(var i in userAccount){
              returnedUser = i;
           }
            return _mapper.Map<AccountLoginResponse>(returnedUser);
        }

}