namespace Encapsulation;

public abstract class Animal
{
	private string _gender;

	public string Gender
	{
		get { return _gender; }
		init { _gender = value; }
	}


	private DateTime _birthDay;

	public DateTime BirthDay
	{
		get { return _birthDay; }
	}
    public Animal(string gender)
    {
        Gender = gender;
		_birthDay = DateTime.Now;
    }


}
