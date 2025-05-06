using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
using Infrastructure.Interface;
namespace Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private const string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=cw-05-05;Password=nozimjanov";

    public List<Employee> GetAllEmployee()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            var sql = @$"select * from employee";
            var result = connection.Query<Employee>(sql).ToList();
            return result;
        }
    }
    public void CreateEmployee()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"insert into employees (departmentid, first_name, last_name, email, hire_date)
                        values
                        (1, 'John', 'Doe', 'john.doe@example.com', '2022-01-15 09:00:00'),
                        (2, 'Jane', 'Smith', 'jane.smith@example.com', '2021-05-20 14:30:00'),
                        (3, 'Alice', 'Johnson', 'alice.johnson@example.com', '2020-08-10 11:15:00'),
                        (4, 'Bob', 'Brown', 'bob.brown@example.com', '2023-02-05 10:00:00'),
                        (5, 'Charlie', 'Davis', 'charlie.davis@example.com', '2021-11-25 15:45:00'),
                        (6, 'David', 'Martinez', 'david.martinez@example.com', '2022-03-12 12:30:00'),
                        (7, 'Eve', 'Wilson', 'eve.wilson@example.com', '2020-06-22 13:20:00'),
                        (8, 'Frank', 'Moore', 'frank.moore@example.com', '2022-09-10 08:10:00'),
                        (9, 'Grace', 'Taylor', 'grace.taylor@example.com', '2023-01-30 16:40:00'),
                        (10, 'Hank', 'Anderson', 'hank.anderson@example.com', '2021-07-17 17:00:00')";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateEmployee(Employee employee)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"update employee set departmentId = '{employee.DepartmentId}', firstName = '{employee.FirstName}', lastName = '{employee.LastName}, email = '{employee.Email}', hireDate = '{employee.HireDate}' where id = '{employee.Id}' ";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteEmployee(int id)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"delete from employee where id = '{id}' ";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
}
