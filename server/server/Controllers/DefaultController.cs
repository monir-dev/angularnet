using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using server.Context;
using server.Dtos;
using server.Repository.Interfaces;
using server.Repository.Persistence;
using server.Utility;
using server.Models;

using SqlKata.Execution;
using server.Utility.SqlKata;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly UnitOfWork _repo;
        private readonly AssetContext _context;

        public DefaultController(AssetContext context)
        {
            this._context = context;
            _repo = new UnitOfWork();

            //_context = new AssetContext();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_context.Acmaster.Select(a => new { a.Amcode, a.CompanyCode, a.Amdetails }).Take(10).ToList());
            return Ok(_repo.Users.MapTo<UserForLoginDto>());
        }
    }
}