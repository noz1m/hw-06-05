using Domain.Entities;
using Infrastructure.Interface;
using Infrastructure.Services;
using Npgsql;

CompanyService companyService = new CompanyService();
DepartmentService departmentService = new DepartmentService();
BranchService branchService = new BranchService();
EmployeeService employeeService = new EmployeeService();

while (true)
{
    try
    {
        System.Console.WriteLine("Employee");
        System.Console.WriteLine("1. Create employee");
        System.Console.WriteLine("2. Get all employee");
        System.Console.WriteLine("3. Update employee");
        System.Console.WriteLine("4. Delete employee");
        System.Console.WriteLine("Departmnet");
        System.Console.WriteLine("5. Create department");
        System.Console.WriteLine("6. Get all department");
        System.Console.WriteLine("7. Update department");
        System.Console.WriteLine("8. Delete department");
        System.Console.WriteLine("9. Get all branch");
        System.Console.WriteLine("10. Create branch");
        System.Console.WriteLine("11. Get all branch");
        System.Console.WriteLine("12. Update branch");
        System.Console.WriteLine("13. Delete branch");
        System.Console.WriteLine("Company");
        System.Console.WriteLine("14. Create company");
        System.Console.WriteLine("15. Get all company");
        System.Console.WriteLine("16. Update company");
        System.Console.WriteLine("17. Delete company");
        System.Console.WriteLine("0. Exit");

        System.Console.WriteLine($"Choose and option");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            System.Console.WriteLine("Create employee");
            System.Console.WriteLine("Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Department Id: ");
            int departmentId = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Hire Date: ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());

            // Employee employee = new Employee();
            // employee.Id = id;
            // employee.DepartmentId = departmentId;
            // employee.FirstName = firstName;
            // employee.LastName = lastName;
            // employee.Email = email;
            // employee.HireDate = hireDate;
            // int result = employeeService.CreateEmployee(employee);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Employee added successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, employee is not added");
            // }
        }
        if (choice == 2)
        {
            System.Console.WriteLine("Get all employee");
            var users = employeeService.GetAllEmployee();
            System.Console.WriteLine("Id\tDepartment Id\tFirst Name\tLast Name\tEmail\tHire Date");
            foreach (var user in users)
            {
                System.Console.WriteLine($"Id: {user.Id}\tDepartment Id: {user.DepartmentId}\tFirst Name: {user.FirstName}\tLast Name: {user.LastName}\tEmail: {user.Email}\tHire Date: {user.HireDate}");
            }
        }
        if (choice == 3)
        {
            System.Console.WriteLine($"Update employee");
            System.Console.WriteLine("Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Department Id: ");
            int departmentId = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Hire Date: ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());

            Employee employee = new Employee()
            {
                Id = id,
                DepartmentId = departmentId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                HireDate = hireDate
            };
            // int result = employeeService.UpdateEmployee(employee);
            // if (employee is null)
            // {
            //     System.Console.WriteLine("Employee not founded");
            // }
            // else
            // {
            //     System.Console.WriteLine("Employee updated successefully");
            // }

        }
        if (choice == 4)
        {
            System.Console.WriteLine($"Delete employee");

            System.Console.WriteLine("Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            // var result = employeeService.DeleteEmployee(id);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Employee deleted successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, employee is not deleted");
            // }
        }
        if (choice == 5)
        {
            System.Console.WriteLine($"Create department");
            System.Console.WriteLine("Department Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Id:");
            int branchId = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Department Name: ");
            string Name = Console.ReadLine(); 
        }
        if (choice == 6)
        {
            System.Console.WriteLine("Get all department");
            var departments = departmentService.GetAllDepartmnet();
            System.Console.WriteLine("Id\tBranch Id\tDepartment Name");
            foreach (var department in departments)
            {
                System.Console.WriteLine($"Id: {department.Id}\tBranch Id: {department.BranchId}\t Department Name : {department.Name}");
            }
        }
        if (choice == 7)
        {
            System.Console.WriteLine($"Update department");
            System.Console.WriteLine("Department Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Id:");
            int branchId = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Department Name: ");
            string Name = Console.ReadLine();

            Department department = new Department()
            {
                Id = id,
                BranchId = branchId,
                Name = Name
            };
            // int result = departmentService.UpdateDepartment(department);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Department updated successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, department is not updated");
            // }
        }
        if (choice == 8)
        {
            System.Console.WriteLine($"Delete department");

            System.Console.WriteLine("Department Id: ");
            int id = int.Parse(Console.ReadLine());

            // int result = departmentService.DeleteDepartment(id);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Department deleted successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, department is not deleted");
            // }
        }

        if (choice == 9)
        {
            System.Console.WriteLine("Create Branch");
            System.Console.WriteLine("Branch Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Name: ");
            string Name = Console.ReadLine();   

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Address: ");
            string Address = Console.ReadLine();

            Branch branch = new Branch()
            {
                Id = id,
                Name = Name,
                Address = Address
            };
            // int result = branchService.CreateBranch(branch);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Branch added successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, branch is not added");
            // }
        }

        if (choice == 10)
        {
            System.Console.WriteLine("Get all Branch");
            var branches = branchService.GetAllBranches();
            System.Console.WriteLine("Id\tBranch Name\tBranch Address");    
            foreach (var branch in branches)
            {
                System.Console.WriteLine($"Id: {branch.Id}\tBranch Name: {branch.Name}\tBranch Address : {branch.Address}");
            }
        }
        if (choice == 11)
        {
            System.Console.WriteLine($"Update branch");
            System.Console.WriteLine("Branch Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Name: ");
            string Name = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Branch Address: ");
            string Address = Console.ReadLine();

            Branch branch = new Branch()
            {
                Id = id,
                Name = Name,
                Address = Address
            };
            // int result = branchService.UpdateBranch(branch);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Branch updated successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, branch is not updated");
            // }
        }
        if (choice == 12)
        {
            System.Console.WriteLine($"Delete branch");

            System.Console.WriteLine("Branch Id: ");
            int id = int.Parse(Console.ReadLine());

            // int result = branchService.DeleteBranch(id);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Branch deleted successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, branch is not deleted");
            // }
        }

        if (choice == 13)
        {
            System.Console.WriteLine("Create Company");
            System.Console.WriteLine("Company Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Company Name: ");
            string Name = Console.ReadLine();

            Company company = new Company()
            {
                Id = id,
                Name = Name
            };
            // int result = companyService.CreateCompany(company);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Company added successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, company is not added");
            // }
        }

        if (choice == 14)
        {
            System.Console.WriteLine("Get all Company");
            var companies = companyService.GetAllCompanies();
            System.Console.WriteLine("Id\tCompany Name");    
            foreach (var company in companies)
            {
                System.Console.WriteLine($"Id: {company.Id}\tCompany Name: {company.Name}");
            }
        }
        if (choice == 15)
        {
            System.Console.WriteLine($"Update company");
            System.Console.WriteLine("Company Id: ");
            int id = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Company Name: ");
            string Name = Console.ReadLine();

            Company company = new Company()
            {
                Id = id,
                Name = Name
            };
            // int result = companyService.UpdateCompany(company);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Company updated successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, company is not updated");
            // }
        }
        if (choice == 16)
        {
            System.Console.WriteLine($"Delete company");

            System.Console.WriteLine("Company Id: ");
            int id = int.Parse(Console.ReadLine());

            // int result = companyService.DeleteCompany(id);
            // if (result > 0)
            // {
            //     System.Console.WriteLine("Company deleted successefully");
            // }
            // else
            // {
            //     System.Console.WriteLine("Error, company is not deleted");
            // }
        }

    }
    catch (Exception Ex)
    {
        System.Console.WriteLine(Ex.Message);
    }
}


















// while (true)
// {
//     try
//     {
//         System.Console.WriteLine();
//         System.Console.WriteLine("-----USER-----");
//         System.Console.WriteLine("1. Add user");
//         System.Console.WriteLine("2. Get all users");
//         System.Console.WriteLine("3. Get specific users");
//         System.Console.WriteLine("4. Update user");
//         System.Console.WriteLine("5. Delete user");
//         System.Console.WriteLine("6. Get all users sorted");
//         System.Console.WriteLine();
//         System.Console.WriteLine("0. Exit");

//         System.Console.Write("Choose an option: ");
//         int choice = int.Parse(Console.ReadLine());

//         if (choice == 1)
//         {
//             System.Console.WriteLine();

//             System.Console.Write("User ID: ");
//             int ID = int.Parse(Console.ReadLine());

//             System.Console.Write("Username: ");
//             string username = Console.ReadLine();

//             System.Console.Write("Email: ");
//             string email = Console.ReadLine();

//             System.Console.Write("Full name: ");
//             string fullName = Console.ReadLine();

//             System.Console.Write("Registration date: ");
//             DateTime registrationDate = DateTime.Parse(Console.ReadLine());

//             User user = new User()
//             {
//                 Username = username,
//                 Email = email,
//                 FullName = fullName,
//                 RegistrationDate = registrationDate
//             };

//             int result = userService.AddUser(user);
//             if (result > 0)
//             {
//                 System.Console.WriteLine("User added successefully");
//             }
//             else
//             {
//                 System.Console.WriteLine("Error, user is not added");
//             }
//         }
//         if (choice == 2)
//         {
//             System.Console.WriteLine();
//             var users = userService.GetAllUsers();
//             System.Console.WriteLine("User ID\tUsername\tEmail\t\t\tFull name\tRegistration date");
//             foreach (var user in users)
//             {
//                 System.Console.WriteLine($"{user.UserId}\t{user.Username}\t{user.Email}\t{user.FullName}\t{user.RegistrationDate:yyyy-MM-dd}");
//             }
//         }
//         if (choice == 3)
//         {
//             System.Console.WriteLine();
//             System.Console.Write("Enter User ID: ");
//             int ID = int.Parse(Console.ReadLine());

//             var user = userService.GetSpecificUsers(ID);
//             if (user is null)
//             {
//                 System.Console.WriteLine("User is not fount");
//             }
//             else
//             {
//                 System.Console.WriteLine("User ID\tUsername\tEmail\t\t\tFull name\tRegistration date");
//                 System.Console.WriteLine($"{user.UserId}\t{user.Username}\t{user.Email}\t{user.FullName}\t{user.RegistrationDate:yyyy-MM-dd}");
//             }
//         }
//         if (choice == 4)
//         {
//             System.Console.WriteLine();

//             System.Console.Write("User ID: ");
//             int ID = int.Parse(Console.ReadLine());

//             System.Console.Write("Username: ");
//             string username = Console.ReadLine();

//             System.Console.Write("Email: ");
//             string email = Console.ReadLine();

//             System.Console.Write("Full name: ");
//             string fullName = Console.ReadLine();

//             System.Console.Write("Registration date: ");
//             DateTime registrationDate = DateTime.Parse(Console.ReadLine());

//             User user = new User()
//             {
//                 UserId = ID,
//                 Username = username,
//                 Email = email,
//                 FullName = fullName,
//                 RegistrationDate = registrationDate
//             };
//             int result = userService.UpdateUser(user);
//             if (result > 0)
//             {
//                 System.Console.WriteLine("User updated successefully");
//             }
//             else
//             {
//                 System.Console.WriteLine("Error, user is not updated");
//             }
//         }
//         if (choice == 5)
//         {
//             System.Console.WriteLine();

//             System.Console.Write("User ID: ");
//             int ID = int.Parse(Console.ReadLine());

//             var result = userService.DeleteUser(ID);
//             if (result > 0)
//             {
//                 System.Console.WriteLine("User deleted successefully");
//             }
//             else
//             {
//                 System.Console.WriteLine("Error, user is not deleted");
//             }
//         }
//         if (choice == 6)
//         {
//             System.Console.WriteLine();
//             var result = userService.GetAllUsersSorted();
//             System.Console.WriteLine("User ID\tUsername\tEmail\t\t\tFull name\tRegistration date");
//             foreach (var user in result)
//             {
//                 System.Console.WriteLine($"{user.UserId}\t{user.Username}\t{user.Email}\t{user.FullName}\t{user.RegistrationDate:yyyy-MM-dd}");
//             }
//         }
//         if (choice == 0)
//         {
//             System.Console.WriteLine("Exiting, bye!");
//             break;
//         }
//     }
//     catch (Exception ex)
//     {
//         System.Console.WriteLine(ex.Message);
//     }
// }