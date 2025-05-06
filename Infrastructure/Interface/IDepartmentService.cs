using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
namespace Infrastructure.Interface;

public interface IDepartmentService
{
    public List<Department> GetAllDepartmnet();
    public void CreateDepartment();
    public void UpdateDepartment(Department department);
    public void DeleteDepartmnet(int id);
}
