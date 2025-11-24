using Unit1.Exercise2; //this is how I import the enum

namespace Unit1.Exercise1;

public class Person
{
    private string _name;
    private int _age;
    private bool _isStudent;
   // private bool _havePets;
   private List<Animal> _animals;

    public Person(string name, int age, bool isStudent)
    {
        _name = name;
        _age = age;
        _isStudent = isStudent;
        _animals = new List<Animal>(); //I initialize it so that it is never null
    }

    public string Name { get => _name; set => _name = value; }
    
    public int Age { get => _age; set => _age = value; }
    
    public bool IsStudent { get => _isStudent; set => _isStudent = value; }
    
    public List<Animal> Animals { get => _animals; } //I remove the set so that animals can only be added by other methods
    
    //public bool HavePets { get => _havePets; set => _havePets = value; }
    
    //public string Information => $"The student is called {Name}. He is {Age} years old.\nIs studying? {GetVariableInfo(IsStudent)}.\nOwn pets? {GetVariableInfo(HavePets)}.";

    public void BeginStudies()
    {
        if (!_isStudent)
        {
            _isStudent = true;
        }
    }
    
    public void EndStudies()
    {
        if (_isStudent)
        {
            _isStudent = false;
        }
    }

    // This method is for Program.cs
    // public void addAnimal(Animal animal)
    // {
    //         _animals.Add(animal);
    // }

    private string GetVariableInfo(bool variableInfo) => variableInfo ? "Yes" : "No";
}