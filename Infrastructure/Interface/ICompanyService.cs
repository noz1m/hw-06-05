using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
namespace Infrastructure.Interface;

public interface ICompanyService
{
    public List<Company> GetAllCompanies();
    public void CreateCompany(Company company);
    public void UpdateCompany(Company company);
    public void DeleteCompany(int id);
}
