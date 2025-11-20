namespace Unit1.Exercise1;

public class Persona
{
    private string _name;
    private int _age;
    private bool _isStudent;
    private bool _havePets;

    public Persona(string name, int age, bool isStudent, bool havePets)
    {
        _name = name;
        _age = age;
        _isStudent = isStudent;
        _havePets = havePets;
    }

    public string Name { get => _name; set => _name = value; }
    
    public int Age { get => _age; set => _age = value; }
    
    public bool IsStudent { get => _isStudent; set => _isStudent = value; }
    
    public bool HavePets { get => _havePets; set => _havePets = value; }
    
    public string Information => $"The student is called {Name}. He is {Age} years old.\nIs studying? {GetVariableInfo(IsStudent)}.\nOwn pets? {GetVariableInfo(HavePets)}.";

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
}