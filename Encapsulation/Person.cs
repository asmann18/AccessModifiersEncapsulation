namespace Encapsulation;

public abstract class Person
{

    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length > 3 && !IsDigitInString(value))
            {
                _name = value;

            }
            else
            {
                Console.WriteLine($"Name set olunmadi duzgun deyer daxil edin.Surname uzunlugu minimum 3 olmalidir ve terkibinde eded olmamalidir,{Surname+Age}");
            }
        }
    }
    private string _surname;

    public string Surname
    {
        get { return _surname; }
        set
        {
            if (value.Length > 3 && !IsDigitInString(value))
            {
                _surname = value;

            }
            else
            {
                Console.WriteLine($"Surname set olunmadi duzgun deyer daxil edin.Surname uzunlugu minimum 3 olmalidir ve terkibinde eded olmamalidir,{Name}");
            }
        }
    }
    private byte _age;

    public byte Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine($"Age fieldi set olunmalidi duzgun eded secin,{Name}");
            }
        }
    }

    public Person(string name, string surname, byte age)
    {
        (Name, Surname, Age) = (name, surname, age);
    }
    public bool IsDigitInString(string s)
    {
        bool result = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                result
                    = true;
            }
        }
        return result;
    }
}
