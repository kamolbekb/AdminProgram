namespace Center.ControlCenter;

public partial class ControlCenter
{
    public void MenthorsShow()
    {
        foreach (var menthor in MenthorsList)
        {
            Console.WriteLine($"{menthor.Id}. {menthor.Name} - Programming Language: {menthor.Language}");
        }
    }
    
    public void CoursesShow()
    {
        foreach (var course in CoursesList)
        {
            Console.WriteLine($"{course.id}. Programming Language: {course.PLanguage}");
        }
    }
    
    public void GetInfo()
    {
        Info info1 = Info.Instance;
        Console.WriteLine("      About Us:\n "+info1.about);
    }
    
    public void AddApplications(string application,string number)
    {
        if (string.IsNullOrWhiteSpace(application))
        {
            throw new Exception();
        }
        int id = ApplicationsList.Count > 0 ? ApplicationsList.Max(c => c.Id) + 1 : 1;
        ApplicationsList.Add(new Applications { Id = id, ApplicationsSt = application, PhoneNumber = number}); 
    }
    
    public void DeleteApplication(int id)
    {
        var application = ApplicationsList.FirstOrDefault(t => t.Id == id);
        if (application != null)
        {
            ApplicationsList.Remove(application);
        }
        else
        {
            Console.WriteLine("Application not found.");
        }
    }

    
}