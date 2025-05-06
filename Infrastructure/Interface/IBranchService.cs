using Domain.Entities;
using Npgsql;
using System.Dynamic;
using Dapper;
using Microsoft.VisualBasic;
namespace Infrastructure.Interface;

public interface IBranchService
{
    public List<Branch> GetAllBranches();
    public void CreateBranch(Branch branch);
    public void UpdateBranch(Branch branch);
    public void DeleteBranch(int id);
}
