using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace testGit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CongTyController : ControllerBase
    {       
        
        [HttpPost]
        public IActionResult GetAll()
        {
            
            return Ok();
        }
    }
}
