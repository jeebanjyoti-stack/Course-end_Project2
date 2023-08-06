using System;
using System.Collections.Generic;
using System.IO;

public static class FileOperations
{
    private const string FileName = @"D:\C# Programme\MainProject\Course-end Project 2\Course-end Project 2\Teacher_Record.txt";

    public static void SaveTeacherRecords(List<Teacher> teachers)
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine("ID,Name,Class,Section");
            foreach (var teacher in teachers)
            {
                writer.WriteLine($"{teacher.ID},{teacher.Name},{teacher.Class},{teacher.Section}");
            }
        }
    }

    public static List<Teacher> LoadTeacherRecords()
    {
        List<Teacher> teachers = new List<Teacher>();

        if (File.Exists(FileName))
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 4)
                    {
                        int id = int.Parse(data[0]);
                        string name = data[1];
                        string classNo = data[2];
                        string section = data[3];

                        Teacher teacher = new Teacher(id, name, classNo, section);

                        teachers.Add(teacher);
                    }
                }
            }
        }

        return teachers;
    }
}