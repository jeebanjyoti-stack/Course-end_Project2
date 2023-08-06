using System;
using System.Collections.Generic;

public static class ConsoleInterface
{
    public static void DisplayMenu()
    {
        Console.WriteLine("1. Add Teacher");
        Console.WriteLine("2. Update Teacher");
        Console.WriteLine("3. View All Teachers");
        Console.WriteLine("4. Exit");
        Console.Write("Input choice: ");
    }

    public static void AddTeacher(List<Teacher> teachers)
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Class: ");
        int classNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Section: ");
        string section = Console.ReadLine();

        Teacher teacher = new Teacher(id, name, classNo, section);
        teachers.Add(teacher);

        Console.WriteLine("Teacher added successfully!");
    }

    public static void UpdateTeacher(List<Teacher> teachers)
    {
        Console.Write("Enter the ID of the teacher to update: ");
        int id = int.Parse(Console.ReadLine());

        Teacher teacherToUpdate = teachers.Find(t => t.ID == id);
        if (teacherToUpdate == null)
        {
            Console.WriteLine("Teacher not found!");
        }
        else
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            int classNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Section: ");
            string section = Console.ReadLine();

            teacherToUpdate.Name = name;
            teacherToUpdate.Class = classNo;
            teacherToUpdate.Section = section;

            Console.WriteLine("Teacher updated successfully!");
        }
    }

    public static void ViewAllTeachers(List<Teacher> teachers)
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teachers found!");
        }
        else
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}
