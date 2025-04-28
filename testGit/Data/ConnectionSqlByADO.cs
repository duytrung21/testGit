using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testGit.Data
{
    public class ConnectionSqlByADO
    {
        private readonly string connectionString = "Data Source=DESKTOP-GRA8A3I;Initial Catalog=TestAPI_ADO;Integrated Security=True";
        public void CreateTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Tao bang Employees
                string createEmployeesTable = @"
                    if object_ID('Employees','U') is null
                    begin
                        create table Employees(     
                            EmployeeID int primary key identity(1,1),
                            Name nvarchar(100) not null);
                    end";
                using (SqlCommand cmd = new SqlCommand(createEmployeesTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return;
        }
    }
}
