using Unit1.Exercise2; //this is how I import the enum

namespace Unit1.Exercise1;

public class Person
{
    private string _name;
    private int _age;
    private bool _isStudent;
   private List<Animal> _animals;

    public Person(string name, int age, bool isStudent,  List<Animal>? animals = null) //animals = null because we want the parameter opcional
    {
        _name = name;
        _age = age;
        _isStudent = isStudent;
        _animals = animals ?? new List<Animal>(); //if animals is not null, use it, if it is null we create a new list empty
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
    
    public void AddAnimal(Animal animal)
    {
            _animals.Add(animal);
    }

    public string InfoAnimals()
    {
        if (_animals.Count == 1)
        {
            var animal = _animals[0];
            return animal.ToString();
        }
        return string.Join(",", _animals.Select(x => x.Name));
    }
}