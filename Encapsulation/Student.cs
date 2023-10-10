namespace Encapsulation;

public class Student:Person
{
	private bool _isOnline;

	public bool IsOnline
	{
		get { return _isOnline; }
		set { _isOnline = value; }
	}
    public Student(string name,string surname,byte age,bool isOnline):base(name,surname,age)
    {
        IsOnline = isOnline;
    }

}
