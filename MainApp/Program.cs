var rabotnik = new EmployeeService();
var otdel = new DepartmentService();
var opit = new ExperienceService();
var rol = new RoleService();

var rabotnik1 = new Employee();
rabotnik1.FirstName = "Abdulloh";
rabotnik1.LastName = "Sheralozoda";
rabotnik1.BirthDate = DateTime.Now;
rabotnik1.Address = "Dushnbe";
rabotnik1.Phone = "502050903";

var otdel1 = new Department();
otdel1.Name = "IT";
otdel1.Description = "C#";

var opit1 = new Experience();
opit1.Company = "SoftClub";
var opit2 = new Experience();
opit1.Company = "Alif";

var rol1 = new Role();
rol1.Name = "User";
var rol2 = new Role();
rol2.Name = "IT";

rabotnik.Add(rabotnik1);
otdel.Add(otdel1);
opit.Add(opit1);
rol.Add(rol1);

var rabotnikShow = rabotnik.GetEmployees();
foreach (var st in rabotnikShow)
{
  System.Console.WriteLine($"FulInfo {st.Id}     {st.FirstName}            {st.LastName}           {st.BirthDate}         {st.Address}      {st.Phone}"); 
}

var otdelShow = otdel.GetDepartments();
foreach (var st in otdelShow)
{
  System.Console.WriteLine($"Department {st.Id}     {st.Name}            {st.Description}"); 
}
var opitshow = opit.GetExperiences();
foreach (var st in opitshow)
{
  System.Console.WriteLine($"Experience {st.Id}     {st.Company}            {st.Company}"); 
}
var rolshow = rol.GetRoles();
foreach (var st in rolshow)
{
  System.Console.WriteLine($"Experience {st.Id}     {st.Name}            {st.Name}"); 
}