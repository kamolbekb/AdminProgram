using System.Net;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Center.ControlCenter;

public partial class ControlCenter
{
    public void AddMenthor(string name, string language)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception();
        }
        int id = MenthorsList.Count > 0 ? MenthorsList.Max(t => t.Id) + 1 : 1;
        MenthorsList.Add(new Menthors { Id = id, Name = name, Language = language});
        // string jsonString = JsonSerializer.Serialize(MenthorsList, new JsonSerializerOptions { WriteIndented = true });
        //
        // // Write JSON to a file (for example)
        // File.WriteAllText(menthorsPath, jsonString);
    }
    
    public void AddCourse(string language)
    {
        if (string.IsNullOrWhiteSpace(language))
        {
            throw new Exception();
        }
        int id = CoursesList.Count > 0 ? CoursesList.Max(c => c.id) + 1 : 1;
        CoursesList.Add(new Courses { id = id, PLanguage = language}); 
    }
    
    public void DeleteMenthor(int id)
    {
        var manthor = MenthorsList.FirstOrDefault(t => t.Id == id);
        if (manthor != null)
        {
            MenthorsList.Remove(manthor);
        }
        else
        {
            Console.WriteLine("Menthor not found.");
        }
    }
    
    public void DeleteCourse(int id)
    {
        var course = CoursesList.FirstOrDefault(t => t.id == id);
        if (course != null)
        {
            CoursesList.Remove(course);
        }
        else
        {
            Console.WriteLine("Course not found.");
        }
    }
    
    public void AddInfo(string about)
    {
        Info info = Info.Instance;
        info.about = Console.ReadLine();
    }

    public void DeleteInfo()
    {
        Console.WriteLine("Are you a sure that you want to delete info?\nType: 'Yes' or 'No'");
        string userType = Console.ReadLine()?.ToUpper();

        if (userType == "YES")
        {
            Info info = Info.Instance;
            info.about = null;
        }
        else if (userType == "NO")
        {
            return;
        }
    }
    
    public void ApplicationsShow()
    {
        Console.WriteLine("We appreciate our clients and keep them anonimous!");
        foreach (var applicationsList in ApplicationsList)
        {
            Console.WriteLine($"{applicationsList.Id}.The application : {applicationsList.ApplicationsSt}");
        }
    }

    public void ApplicatonsDisplay()
    {
        foreach (var VARIABLE in ApplicationsList)
        {
            Console.WriteLine($"{VARIABLE.Id}. The application: {VARIABLE.ApplicationsSt}\nNumber of client: {VARIABLE.PhoneNumber}");
        }
    }
}