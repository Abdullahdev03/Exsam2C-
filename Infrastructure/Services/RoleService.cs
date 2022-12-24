public class RoleService
{
  List<Role> roles;
  public RoleService()
  {
    roles = new List<Role>();
  }
  public List<Role> GetRoles()
  {
    return roles;
  }
  public void  Add(Role employee)
  {
    roles.Add(employee);
  }
  public void  Update(Role role, int id)
  {
    var find = roles.Find(x => x.Id == role.Id);
    if (find == null) return;
    find.Name = role.Name;
    find.Description = role.Description;
  }
  public Role GetRoleById(int id)
  {
    return GetRoleById(id);
  }
  public void Delete(int id)
  {
    var find = roles.Find(x => x.Id == id);
    if (find == null) return;
    roles.Remove(find);
  }
  public int Count()
  {
    return roles.Count;
  }
}