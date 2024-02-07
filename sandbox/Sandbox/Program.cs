using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Student student = new Student("Brigham", "234");
        string name = student.GetName();
        
        string number = student.GetName();
        Console.WriteLine(name);
        Console.WriteLine($"Student Number: {number}");
    
    
    }
}
public class Person
{
    private string _name;
    public Person (string name)
    {
        _name=name;
    }
    


    public string GetName()
    {
        return _name;
    }
}
public class Student:Person
{
    private string _number;
    public Student(string name,string number):base(name)
    {
        _number=number;
        
        
    }
    public string GetNumber()
    {
        return _number;
    }
}
  