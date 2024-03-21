using Lab4._2;

Console.WriteLine("Student of College:");
StudentCollege sv1 = new StudentCollege("Tu", 2002, 9.2, 2.3, 3);
sv1.Display();
Console.WriteLine("Average of score: {0}\n", sv1.Average());
Console.WriteLine("Student of University:");
StudentUniversity sv2 = new StudentUniversity("Tu2", 2002, 9.3, 4.5, 6,9.5);
sv2.Display();
Console.WriteLine("Average of score: {0}\n", sv2.Average());