using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Teacher> teachers = FileOperations.LoadTeacherRecords();

        bool exit = false;
        while (!exit)
        {
            ConsoleInterface.DisplayMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConsoleInterface.AddTeacher(teachers);
                    break;
                case 2:
                    ConsoleInterface.UpdateTeacher(teachers);
                    break;
                case 3:
                    ConsoleInterface.ViewAllTeachers(teachers);
                    break;
                case 4:
                    FileOperations.SaveTeacherRecords(teachers);
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}