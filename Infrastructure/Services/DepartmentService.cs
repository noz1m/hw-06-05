using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
using Infrastructure.Interface;
namespace Infrastructure.Services;

public class DepartmentService : IDepartmentService
{
    private const string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=cw-05-05;Password=nozimjanov";

    public List<Department> GetAllDepartmnet()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"select * from department";
            var result = connection.Query<Department>(sql).ToList();
            return result;
        }
    }
    public void CreateDepartment()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"insert into departments (branchId, name)
                        values
                        (1, 'Human Resources'),
                        (2, 'Finance'),
                        (3, 'Research and Development'),
                        (4, 'Marketing'),
                        (5, 'Sales'),
                        (6, 'Customer Support'),
                        (7, 'IT Department'),
                        (8, 'Logistics'),
                        (9, 'Legal'),
                        (10, 'Product Management');";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");

        }
    }
    public void UpdateDepartment(Department department)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"update department set branchId = '{department.BranchId}', name = '{department.Name}' where id = '{department.Id}' ";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteDepartmnet(int id)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"delete from department where id = '{id}' ";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
}
