namespace Encapsulation;

public class Dog:Animal
{
	private string _name;

	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	private string _breed;

	public string Breed
	{
		get { return _breed; }
		init { _breed = value; }
	}
    public Dog(string gender,string name,string breed):base(gender)
    {
        Name = name;
		Breed = breed;
    }

}
