namespace Unit1.Exercise2;

public class Animal
{
    private string _name;
    private enum TypeAnimal;
    private int _age;
    private double _weight;
    private bool _isAggressive;
    
    public  Animal(string name, int age, double weight, bool isAggressive)
    {
        _name = name;
        _age = age;
        _weight = weight;
        _isAggressive = isAggressive;

    }
    
    public string Name { get => _name; set => _name = value; }
    
    public int Age { get => _age; set => _age = value; }
    
    public double Weight { get => _weight; set => _weight = value; }
    
    public bool IsAggressive { get => _isAggressive; set => _isAggressive = value; }
    
    


}