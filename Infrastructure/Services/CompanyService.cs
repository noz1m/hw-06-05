using System.Dynamic;
using Dapper;
using Domain.Entities;
using Microsoft.VisualBasic;
using Npgsql;
using Infrastructure.Interface;
namespace Infrastructure.Services;

public class CompanyService : ICompanyService
{
    private const string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=cw-05-05;Password=nozimjanov";
    public List<Company> GetAllCompanies()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = $"select * from company";
            var result = connection.Query<Company>(sql).ToList();
            return result;
        }
    }
    public void CreateCompany(Company company)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"insert into companies (name, createdat)
                        values 
                        ('TechLeader', '2023-01-15'),
                        ('AlphaSoft', '2023-02-20 ),
                        ('InnovaPro', '2023-03-05'),
                        ('GlobalTrade', '2023-04-10'),
                        ('NextDigital', '2023-05-01'),
                        ('SmartSolutions', '2023-06-18'),
                        ('EcoSphere', '2023-07-22'),
                        ('LogisticPlus', '2023-08-30'),
                        ('ITWorld', '2023-09-12'),
                        ('RoboTech', '2023-10-05');";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateCompany(Company company)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"update company set name = '{company.Name}', createdat = '{company.CreatedAt}' where id = {company.Id};";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteCompany(int id)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"delete from company where id = '{id}'";
            var result = connection.Execute(sql);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
}