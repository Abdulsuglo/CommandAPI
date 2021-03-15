using System.Collections.Generic;
using CommandAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController:ControllerBase
    {
        private readonly ICommandAPIRepo _rpository;

        public CommandsController(ICommandAPIRepo repository)
        {
            _rpository=repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[]{"This","is","hard","coded"};
        }
    }
}