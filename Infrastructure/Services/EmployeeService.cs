public class EmployeeService
{
  List<Employee> employees;

  public EmployeeService()
  {
    employees = new List<Employee>();
  }
  public List<Employee> GetEmployees()
  {
    return employees;
  }
  public void Add(Employee employee)
  {
    employees.Add(employee);
  }
  public void  Update(Employee employee, int id)
  {
    var find = employees.Find(x => x.Id == employee.Id);
    if (find == null) return;
    find.FirstName = employee.FirstName;
    find.LastName = employee.LastName;
    find.BirthDate = employee.BirthDate;
    find.Address = employee.Address;
    find.Phone = employee.Phone;
  }
  public Employee GetEmployeetById(int id)
  {
    return GetEmployeetById(id);
  }
  public List<Role> GetRolesByUserId(int id)
  {
    return GetRolesByUserId(id);
  }
  public List<Experience> GetExperiencesByUserId(int id)
  {
    return GetExperiencesByUserId(id);
  }
  public void Delete(int id)
  {
    var find = employees.Find(x => x.Id == id);
    if (find == null) return;
    employees.Remove(find);
  }
  public int Count()
  {
    return employees.Count;
  }
}