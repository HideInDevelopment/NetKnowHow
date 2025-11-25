using Unit1.Exercise2; //this is how I import the enum

namespace Unit1.Exercise1;

public class Person
{
    private string _name;
    private int _age;
    private bool _isStudent;
   // private bool _havePets;
   private List<Animal> _animals;

    public Person(string name, int age, bool isStudent,  List<Animal> animals)
    {
        _name = name;
        _age = age;
        _isStudent = isStudent;
        _animals = animals;
    }
    
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

    public string Information()
    {
        return _animals.Count == 0
            ? $"The student is called {Name}. He is {Age} years old.\nIs studying? {GetVariableInfo(IsStudent)}.\nOwn pets? No."
            : $"The student is called {Name}. He is {Age} years old.\nIs studying? {GetVariableInfo(IsStudent)}.\nOwn pets? Yes: {InfoAnimals()}";
    }

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
    
    private string GetVariableInfo(bool variableInfo) => variableInfo ? "Yes" : "No";
    
    public void addAnimal(Animal animal)
    {
            _animals.Add(animal);
    }

    public string InfoAnimals()
    {
        if (_animals.Count == 1)
        {
            var animalList = _animals[0];
            return animalList.ToString();
        }
        else
        {
            var animalsList = string.Join(",", _animals.Select(animal => animal.Name));
            return animalsList;
        }
        
    }
}