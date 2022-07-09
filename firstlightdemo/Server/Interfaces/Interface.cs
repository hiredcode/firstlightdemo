using firstlightdemo.Shared.Models;
namespace firstlightdemo.Server.Interfaces
{
    public interface IDepartment
    {
        public List<Department> GetDepartmentDetails();
        public void AddDepartment(Department department);
        public void UpdateDepartmentDetails(Department department);
        public Department GetDepartmentData(int id);
        public void DeleteDepartment(int id);
    }
}
