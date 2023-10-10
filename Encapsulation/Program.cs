namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new("Zulfiyye", "Qurbanova", 19, true);
            Student student2 = new("Sebuhi", "Camalzade", 19, false);
            Student student3 = new("Asiman", "Qasimzade", 20, true);
            Group group = new("AB104");
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetAll();
        }
    }
}