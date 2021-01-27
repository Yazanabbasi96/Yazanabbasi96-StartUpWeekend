using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using QPcBackend.Entities;
using QPcBackend.Models.Accounts;
using System.Collections.Generic;
//using QPcBackend.Services;



namespace QPcBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountServices _accountService;
         private readonly IPartsService _partsService;

        public AccountsController(IAccountServices accountService, IPartsService partsService)
        {
            _accountService = accountService;
            _partsService = partsService;
        }

        [HttpPost("user-login")]
        public ActionResult<AccountLoginResponse> LoginRequest(AccountLoginRequest model){
            var response = _accountService.loginRequest(model);
            return Ok(response);
        }

        [HttpGet("get-all-parts")]
         public ActionResult<List<PCPart>> GetAllParts(){
            var response = _partsService.getAllParts();
            return Ok(response);
        }
    }
}