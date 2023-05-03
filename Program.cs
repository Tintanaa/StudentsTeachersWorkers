using Studteachworkers.Menu;
using Studteachworkers.Input;
using Studteachworkers.University;
using Studteachworkers.Actions;

Menu menu = new Menu();
StudentInput studentinput = new StudentInput();
TeacherInput teacherinput= new TeacherInput();
ManagersInput managersInput = new ManagersInput();
WorkersInput workersinput = new WorkersInput();
Studentlist studentslist = new Studentlist();
Teacherlist teacherslist = new Teacherlist();
Managerlist managerslist = new Managerlist();
Workerslist workerslist = new Workerslist();
Manageractions manactions = new Manageractions();
StudentsActions studactions = new StudentsActions();
Teacheractions teachactions = new Teacheractions();
WorkerActions workactions = new WorkerActions();
while (true)
{
    menu.Mainmenu();
    int ChooseMainmenu = Convert.ToInt32(Console.ReadLine());
    switch(ChooseMainmenu)
    {
        case 1:
            Console.WriteLine("1-student, 2-teacher, 3-manager, 4-worker");
            int ChooseInput = Convert.ToInt32(Console.ReadLine());
            switch (ChooseInput)
            {
                case 1:
                    studentinput.StudInput();
                    break;
                case 2:
                    teacherinput.Teacherinput();
                    break;
                case 3:
                    managersInput.Managersinput();
                    break;
                case 4:
                    workersinput.WorkerInput();
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Output 1-students, 2-teachers, 3-managers, 4-workers");
            int ChooseInput2 = Convert.ToInt32(Console.ReadLine());
            switch (ChooseInput2)
            {
                case 1:
                    studentslist.WriteToConsole(studentslist.studentlist);
                    break;
                case 2:
                    teacherslist.WriteToConsole(teacherslist.teacherlist);
                    break;
                case 3:
                    managerslist.WriteToConsole(managerslist.ManagerList);
                    break;
                case 4:
                    workerslist.WriteToConsole(workerslist.WorkersList);
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Who you are? 1-student, 2-teacher, 3-manager, 4-worker");
            int ChooseInput3 = Convert.ToInt32(Console.ReadLine());
            switch (ChooseInput3)
            {
                case 1:
                    Console.WriteLine("Your actions: None. Not yet, pally");
                    break;
                case 2:
                    Console.WriteLine("1) Exam, 2) Dolzhnyki");
                    break;
                case 3:
                    Console.WriteLine("1) Izdaem prikaz");
                    break;
                case 4:
                    Console.WriteLine("You are making great job. Just rest. You deserved");
                    break;
            }
            break;

    }
}
