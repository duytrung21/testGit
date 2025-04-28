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
        private readonly string connectionString = "Data Source=DESKTOP-GRA8A3I;Initial Catalog=TestAPI_ADO;Integrated Security=True";
        [HttpPost]
        public IActionResult GetAll()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select ID, Name from Employees";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return Ok();
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
