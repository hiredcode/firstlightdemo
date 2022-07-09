using firstlightdemo.Server.Interfaces;
using firstlightdemo.Server.Models;
using firstlightdemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace firstlightdemo.Server.Services
{
    public class DepartmentManager : IDepartment
    {
        readonly DatabaseContext _dbContext = new();

        public DepartmentManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all Department details
        public List<Department> GetUserDetails()
        {
            try
            {
                return _dbContext.Departments.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new depqrtment
        public void AddDepartment(Department department)
        {
            try
            {
                _dbContext.Departments.Add(department);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }


        //To Update a department
        public void UpdateDepartmentDetails(Department department)
        {
            try
            {
                _dbContext.Entry(department).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a department
        public Department GetDepartmentData(int id)
        {
            try
            {
                Department? department = _dbContext.Departments.Find(id);
                if (department != null)
                {
                    return department;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //To Delete department
        public void DeleteDepartment(int id)
        {
            try
            {
                Department? department = _dbContext.Departments.Find(id);
                if (department != null)
                {
                    _dbContext.Departments.Remove(department);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Department> GetDepartmentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
