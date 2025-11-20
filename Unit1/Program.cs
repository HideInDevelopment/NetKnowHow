using Unit1.Exercise1;

namespace  NetKnowHow;
class Program
{
    private const string Separator = "-----------------------------";
    static void Main(string[] args)
    {
        Persona student = new Persona("Manuel", 29, false, true);
        Console.WriteLine(student.ToString());
        Console.WriteLine(Separator);
        Console.WriteLine("Ending studies...");
        student.endStudies();
        Console.WriteLine(Separator);
        // after called this method, the studies of the student have ended or started
        Console.WriteLine(student.ToString());
        
    }
}