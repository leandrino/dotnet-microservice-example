using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassesService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClassesService.API.Controllers
{
    [ApiController]
    [Route("school-classes")]
    public class ClassesController : ControllerBase
    {
        private readonly ILogger<ClassesController> _logger;

        public ClassesController(ILogger<ClassesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public SchoolClass Get()
        {
            return new SchoolClass(
                new Guid(),
                "Banana",
                2,
                "1st grade"
            );
        }
    }
}