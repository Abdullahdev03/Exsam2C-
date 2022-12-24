public class DepartmentService
{
  List<Department> departments;
  public DepartmentService()
  {
    departments = new List<Department>();
  }
  public List<Department> GetDepartments()
  {
    return departments;
  }
  public void Add(Department department)
  {
    departments.Add(department);
  }
  public void Update(Department department, int id)
  {
    var find = departments.Find(x => x.Id == department.Id);
    if (find == null) return;
    find.Name = department.Name;
    find.Description = department.Description;
  }
  public Department GetDepartmentById(int id)
  {
    return GetDepartmentById(id);
  }
  public void Delete(int id)
  {
    var find = departments.Find(x => x.Id == id);
    if (find == null) return;
    departments.Remove(find);
  }
  public int Count()
  {
    return departments.Count;
  }
}