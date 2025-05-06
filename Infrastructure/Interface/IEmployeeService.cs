using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
namespace Infrastructure.Interface;

public interface IEmployeeService
{
    public List<Employee> GetAllEmployee();
    public void CreateEmployee();
    public void UpdateEmployee(Employee employee);
    public void DeleteEmployee(int id);
}
