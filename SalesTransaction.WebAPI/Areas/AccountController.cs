﻿using Microsoft.AspNetCore.Mvc;
using SalesTransaction.Model;
using SalesTransaction.Service.Service;
using SalesTransaction.WebAPI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTransaction.WebAPI.Areas
{
    public class AccountController : BaseController
    {
        private ILoginService _service;
        public AccountController(ILoginService service)
        {
            _service = service; //defining depedency

        }
      
        [HttpGet]
        public string getURL()
        {
            return ("succedd");
        }

        [HttpGet]
        public IActionResult UserDetail(string json)
        {
            var data = _service.GetDetails(json);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult UserLogin([FromBody] MvUserLogin login)
        {
            var data = _service.GetLogin(login);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        
    }
}
