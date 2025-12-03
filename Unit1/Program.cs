using Unit1.Exercise1;
using Unit1.Exercise2;

namespace  Unit1;
public class Program
{
    private const string Separator = "-----------------------------";

    public static void Main(string[] args)
    {
        var animal1 = new Animal("Pipo", 5, 3.5, false, TypeAnimal.Dog);
        var animalPlus = new Animal("Yaki", 2, 3.5, false, TypeAnimal.Cat);
        var student1 = new Person("Natalia", 25, true, new List<Animal>{ animal1, animalPlus });

     Console.WriteLine(student1.Information());
     Console.WriteLine(Separator);

     Console.WriteLine("Ending studies...");
     student1.EndStudies();
     Console.WriteLine(Separator);
     Console.WriteLine(student1.Information());

     Console.WriteLine(Separator);

     var animal2 = new Animal("Tako", 2, 10.5, true, TypeAnimal.Cat);
     var student2 = new Person("Manuel", 29, false);

     Console.WriteLine(student2.Information());
     Console.WriteLine(Separator);

     Console.WriteLine("Beginning studies...");
     student2.BeginStudies();
     Console.WriteLine(Separator);
     Console.WriteLine("Adding animals or no...");
     Question(student2, animal2);
     Console.WriteLine(student2.Information());
     
}

    public static void Question(Person student, Animal pet)
    {
        Console.WriteLine("Do u want to add a Animal? yes (y) or no (press any other key)");
        var answer = Console.ReadLine();
        if (answer.ToLower().Equals("y"))
        {
            student.AddAnimal(pet);
            return;
        }
        Console.WriteLine("You choose to not add a pet.");
    }
}