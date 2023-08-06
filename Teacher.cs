using System;

public class Teacher
{
    private string classNo;

    public int ID { get; set; }
    public string Name { get; set; }
    public int Class { get; set; }
    public string Section { get; set; }

    public Teacher(int id, string name, int classNo, string section)
    {
        ID = id;
        Name = name;
        Class = classNo;
        Section = section;
    }

    public Teacher(int id, string name, string classNo, string section)
    {
        ID = id;
        Name = name;
        Class = int.Parse(classNo); 
        Section = section;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Class: {Class}, Section: {Section}";
    }
}
