using Students_Management_system;
using System.Collections;

Hashtable studentTable = new Hashtable();

int chon;
try
{
    do
    {
        Console.WriteLine("\nPlease select an option:");
        Console.WriteLine("==================================");
        Console.WriteLine("1. Insert new student...");
        Console.WriteLine("2. Display all the student list...");
        Console.WriteLine("3. Calculator average mark...");
        Console.WriteLine("4. Exit.");
        Console.WriteLine("==================================");
        Console.Write("Option: ");

        chon = int.Parse(Console.ReadLine());
        switch (chon)
        {
            case 1:
                try
                {
                    Student Stud = new Student();
                    Console.WriteLine("1. Insert new student...");

                    Console.Write("Input student ID: ");
                    Stud.StudID = int.Parse(Console.ReadLine());

                    Console.Write("Input student Name: ");
                    Stud.StudName = Console.ReadLine();

                    Console.Write("Input student Gender: ");
                    Stud.StudGender = Console.ReadLine();

                    Console.Write("Input student Age: ");
                    Stud.StudAge = int.Parse(Console.ReadLine());

                    Console.Write("Input student Class: ");
                    Stud.StudClass = Console.ReadLine();

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("\t input mark {0}: ", i + 1);
                        Stud[i] = int.Parse(Console.ReadLine());

                    }

                    studentTable[Stud.StudID] = Stud;

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            case 2:
                foreach (DictionaryEntry entry in studentTable)
                {
                    if (entry.Value is Student student)
                    {
                        student.CalAvg();
                        student.Print();
                    }
                }
                break;

            case 3:
                foreach (DictionaryEntry entry in studentTable)
                {
                    if (entry.Value is Student student)
                    {

                        student.Print();
                        Console.WriteLine("Studdent Avg Mark: \t" + student.CalAvg());
                    }
                }
                break;


            default:
                Console.WriteLine("Please chose from 1 to 4");
                break;
        }

    } while (chon != 4);
}
catch(FormatException e) 
{
    Console.WriteLine("Chon la kieu int");
}