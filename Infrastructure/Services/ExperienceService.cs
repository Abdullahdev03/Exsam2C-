public class ExperienceService
{
  List<Experience> experiences;
  public ExperienceService()
  {
    experiences = new List<Experience>();
  }
  public List<Experience> GetExperiences()
  {
    return experiences;
  }
  public void Add(Experience experience)
  {
    experiences.Add(experience);
  }
  public void  Update(Experience experience)
  {
    var find = experiences.Find(x => x.Id == experience.Id);
    if (find == null) return;
    find.Name = experience.Name;
    find.Description = experience.Description;
    find.Employeeld = experience.Employeeld;
  }
  public Experience GetExperienceById(int id)
  {
    return GetExperienceById(id);
  }
  public void Delete(int id)
  {
    var find = experiences.Find(x => x.Id == id);
    if (find == null) return;
    experiences.Remove(find);
  }
  public int Count()
  {
    return experiences.Count;
  }

}