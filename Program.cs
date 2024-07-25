using System.ComponentModel;
using System.Threading.Channels;

namespace Center;

class Program
{
    public static void Main(string[] args)
    {
        bool exitMain = false;
        var controlCenter = new ControlCenter.ControlCenter();
        while (!exitMain)
        {
            bool exit = false;
            Console.Clear();
            Console.WriteLine("Welcome to the Learning Center!");
            Console.WriteLine("Are you a Student (S) or part of the Learning Center (LC)?");
            string userType = Console.ReadLine()?.ToUpper();
           

            
            if (userType == "S")
            {
                Console.WriteLine("Enter your name: ");
                
                Student student = new Student();
                student.Name = Console.ReadLine();
                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {student.Name}\n");
                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Courses (Read)");
                    Console.WriteLine("2. Mentors (Read)");
                    Console.WriteLine("3. About Learning Center (Read)");
                    Console.WriteLine("4. Applications (Create/Read/Update/Delete)");
                    Console.WriteLine("0. Exit to previous menu");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());
                
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("You are viewing Courses: ");
                            controlCenter.CoursesShow();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("You are viewing Mentors.");
                            controlCenter.MenthorsShow();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("You are viewing About Learning Center.");
                            controlCenter.GetInfo();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("You are managing Applications (CRUD operations).");
                            controlCenter.ApplicationsShow();
                            Console.WriteLine();
                            Console.WriteLine("Chose action:");
                            Console.WriteLine("1.Add New Course");
                            Console.WriteLine("2.Delete from existing");
                            Console.WriteLine("0.Exit menu");
                            string str = Console.ReadLine();
                            switch (str)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Write down your application");
                                    string app = Console.ReadLine();
                                    Console.WriteLine("Please leave your number so we could call you and solve the problem;)");
                                    string number = Console.ReadLine();
                                    controlCenter.AddApplications(app,number);
                                    Console.WriteLine("Added successfuelly");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    controlCenter.ApplicationsShow();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter Id of Application to delete:");
                                    int id = int.Parse(Console.ReadLine());
                                    controlCenter.DeleteApplication(id);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "0":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid value!");
                                    break;
                            }
                            
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Exiting to previous menu...");
                            exit = true;
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
                            return;
                    }
                }
            }
            else if (userType == "LC")
            {
                Console.WriteLine("Enter your name: ");
                LCenter lCenter = new LCenter();
                lCenter.Name = Console.ReadLine();
                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {lCenter.Name}\n");
                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Courses (Create/Read/Update/Delete)");
                    Console.WriteLine("2. Mentors (Create/Read/Update/Delete)");
                    Console.WriteLine("3. About Learning Center (Create/Read/Update/Delete)");
                    Console.WriteLine("4. Applications (Read)");
                    Console.WriteLine("0. Exit to previous menu");

                    int choice = int.Parse(Console.ReadLine());
                

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("You are managing Courses (CRUD operations).");
                            controlCenter.CoursesShow();
                            Console.WriteLine();
                            Console.WriteLine("Chose action:");
                            Console.WriteLine("1.Add New Course");
                            Console.WriteLine("2.Delete from existing");
                            Console.WriteLine("0.Exit menu");
                            string answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Enter Language of Course: ");
                                    string language = Console.ReadLine();
                                    controlCenter.AddCourse(language);
                                    Console.WriteLine("Successfully Added!");
                                    Console.ReadKey();
                                    Console.Clear();
                                break;
                                case "2":
                                    Console.Clear();
                                    controlCenter.CoursesShow();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter Courses Id:");
                                    int id = int.Parse(Console.ReadLine());
                                    controlCenter.DeleteCourse(id);
                                    Console.WriteLine("Deleted!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "0":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input!!!");
                                    break;
                            }
                            break;
                        
                        case 2:
                            Console.Clear();
                            Console.WriteLine("You are managing Mentors (CRUD operations).");
                            controlCenter.MenthorsShow();
                        
                            Console.WriteLine();
                            Console.WriteLine("Chose action:");
                            Console.WriteLine("1.Add New Course");
                            Console.WriteLine("2.Delete from existing");
                            Console.WriteLine("0.Exit menu");
                        
                            string answerM = Console.ReadLine();
                            switch (answerM)
                            {
                                case "1":
                                    Console.Clear(); 
                                    Console.WriteLine("Enter Name of menthore ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Enter language that he codes in:");
                                    string language = Console.ReadLine();
                                    controlCenter.AddMenthor(name,language); 
                                    Console.WriteLine("Successfully Added!");
                                    Console.ReadKey();
                                    Console.Clear();
                                        break;
                                case "2":
                                    Console.Clear();
                                    controlCenter.MenthorsShow();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter Methor's Id:");
                                    int id = int.Parse(Console.ReadLine());
                                    controlCenter.DeleteMenthor(id);
                                    Console.WriteLine("Deleted");
                                    Console.ReadKey();
                                    Console.Clear();
                                        break;
                                case "0":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input!!!");
                                    break;
                            }
                        break;
                    case 3:
                            Console.Clear();
                        Console.WriteLine("You are managing About Learning Center (CRUD operations).");
                        controlCenter.MenthorsShow();
                        
                            Console.WriteLine();
                            Console.WriteLine("Chose action:");
                            Console.WriteLine("1.Add About Info");
                            Console.WriteLine("2.Delete existing info");
                            Console.WriteLine("0.Exit menu");
                        
                            string answerA = Console.ReadLine();
                            switch (answerA)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Enter info:");
                                    string info = Console.ReadLine();
                                    controlCenter.AddInfo(info);
                                    Console.WriteLine("Successfully Added1");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    controlCenter.DeleteInfo();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "0":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input!!!");
                                    break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("You are viewing Applications.");
                            Console.WriteLine();
                            controlCenter.ApplicatonsDisplay();
                            Console.ReadKey();
                            Console.Clear();
                            break; 
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Exiting to previous menu...");
                            exit = true;
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice.");
                         break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please run the program again.");
            } 
        }
    }
}