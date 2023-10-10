namespace Encapsulation;

public class Group
{
	private string _groupName;

	public string GroupName
	{
		get { return _groupName; }
		set { _groupName = value; }
	}
	private Student[] _students;

	public Student[] Students
	{
		get { return _students; }
		set { _students = value; }
	}
    public Group(string groupName)
    {
        GroupName= groupName;
		Students = new Student[0];
    }


	public void AddStudent(Student student)
	{
		Array.Resize(ref _students, Students.Length + 1);
		Students[Students.Length-1] = student;
        Console.WriteLine($"Student {student.Name} is successfully added");
    }
	public void GetAll()
	{
		Console.WriteLine($"{GroupName}s` students: ");
		if (Students.Length == 0)
		{
            Console.WriteLine("Group is empty");
			return;
        }
        foreach (var student in Students)
		{
			Console.WriteLine($"Name:{student.Name}   Surname:{student.Surname}");
        }
	}
	public void GetOnlineStudents()
	{
        Console.WriteLine($"{GroupName}s` Online students: ");
        if (Students.Length == 0)
        {
            Console.WriteLine("Group is empty");
            return;
        }
		foreach (var student in Students)
		{
			if (student.IsOnline)
			{
				Console.WriteLine($"Name:{student.Name}   Surname:{student.Surname}");
			}
		}
    }

    public void GetOfflineStudents()
    {
        Console.WriteLine($"{GroupName}s` Offline students: ");
        if (Students.Length == 0)
        {
            Console.WriteLine("Group is empty");
            return;
        }
        foreach (var student in Students)
        {
            if (!student.IsOnline)
            {
                Console.WriteLine($"Name:{student.Name}   Surname:{student.Surname}");
            }
        }
    }
}
