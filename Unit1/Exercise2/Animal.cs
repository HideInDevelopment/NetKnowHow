namespace Unit1.Exercise2;

public class Animal
{
    private string _name;
    private TypeAnimal _type;
    private int _age;
    private double _weight;
    private bool _isAggressive;
    
    public Animal(string name, int age, double weight, bool isAggressive, TypeAnimal type)
    {
        _name = name;
        _age = age;
        _weight = weight;
        _isAggressive = isAggressive;
        _type = type;

    }
    
    public string Name { get => _name; set => _name = value; }
    
    public int Age { get => _age; set => _age = value; }
    
    public double Weight { get => _weight; set => _weight = value; }
    
    public bool IsAggressive { get => _isAggressive; set => _isAggressive = value; }
    
    public TypeAnimal Type { get => _type; set => _type = value; }
    
    private string GetVariableInfo(bool variableInfo) => variableInfo ? "Yes" : "No";

    public override string ToString()
    {
        return $"The name of the animal is {Name}, he/she is {Age} years old, and the weight is {Weight}, The pet is aggressive? {GetVariableInfo(_isAggressive)}";
    }
}