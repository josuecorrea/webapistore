﻿using CWWebStore.Domain.Commands.UserCommands;
using CWWebStore.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CWWebStore.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApplicationService _service;

        public UserController(IUserApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/users")]
        [Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var users = _service.List();
            return CreateResponse(HttpStatusCode.OK, users);
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new RegisterUserCommand(
                email: (string)body.email,
                password: (string)body.password,
                isAdmin: (bool)body.isAdmin
            );

            var user = _service.Register(command);

            return CreateResponse(HttpStatusCode.Created, user);
        }
    }
}
