using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testGit.Data;

namespace testGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DbHelper _dbHelper;
        public ProductsController()
        {
            _dbHelper = new DbHelper();
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            try
            {
                var products = _dbHelper.GetProducts();
                return Ok(products);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
