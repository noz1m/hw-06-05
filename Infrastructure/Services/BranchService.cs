using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
using Infrastructure.Interface;
namespace Infrastructure.Services;

public class BranchService : IBranchService
{
    private const string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=cw-05-05;Password=nozimjanov";

    public List<Branch> GetAllBranches()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"select * from branch";
            var result = connection.Query<Branch>(sql).ToList();
            return result;
        }
    }
    public void CreateBranch(Branch branch)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"insert into branches (companyId, name, address)
                        values
                        (1, 'TechLeader - New York Branch', '123 Main St, New York, NY'),
                        (2, 'AlphaSoft - Boston Office', '45 Innovation Blvd, Boston, MA'),
                        (3, 'InnovaPro - Chicago Hub', '789 Market Ave, Chicago, IL'),
                        (4, 'GlobalTrade - LA Branch', '500 Sunset Blvd, Los Angeles, CA'),
                        (5, 'NextDigital - Seattle Office', '111 Pine St, Seattle, WA'),
                        (6, 'SmartSolutions - Austin Division', '88 Tech Park, Austin, TX'),
                        (7, 'EcoSphere - Denver Site', '22 Greenway Rd, Denver, CO'),
                        (8, 'LogisticPlus - Miami Branch', '300 Cargo Ln, Miami, FL'),
                        (9, 'ITWorld - Atlanta Office', '1500 Peachtree St, Atlanta, GA'),
                        (10, 'RoboTech - San Francisco HQ', '1 Robotics Plaza, San Francisco, CA');";
            var result = connection.Execute(sql,branch);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void UpdateBranch(Branch branch)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"update branch set companyId = @CompanyId, name = @Name, address = @address where id = @id ";
            var result = connection.Execute(sql,branch);
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
    public void DeleteBranch(int id)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var sql = @$"delete from branch where id = @id ";
            var result = connection.Execute(sql, new {id = id});
            Console.WriteLine(result > 0 ? "Success" : "Failed");
        }
    }
}
