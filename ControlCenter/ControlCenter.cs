namespace Center.ControlCenter;

public partial class ControlCenter
{
    private List<Courses> CoursesList = new List<Courses>();
    private List<Applications> ApplicationsList = new List<Applications>();
    private List<Menthors> MenthorsList = new List<Menthors>();
    
    private string menthorsPath = @"ControlCenter/Pathes/MenthorList.json";

    private string courseJson = @"ControlCenter/Pathes/CoursesList.json";

    private string applicationsJson = @"ControlCenter/Pathes/ApplicationsList.json";

    private string aboutJson = @"ControlCenter/Pathes/About.json";
}