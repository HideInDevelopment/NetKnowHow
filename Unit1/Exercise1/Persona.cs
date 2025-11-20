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

    public void endStudies()
    {
        if (IsStudent == true)
        {
            IsStudent = false;
        }
        else
        {
            IsStudent = true;
        }
    }

    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }
    
    public int Age 
    { 
        get => _age; 
        set => _age = value; 
    }
    
    public bool IsStudent 
    { 
        get => _isStudent; 
        set => _isStudent = value; 
    }
    
    public bool HavePets 
    { 
        get => _havePets; 
        set => _havePets = value; 
    }
    

    public override string ToString()
    {
        return "The student is called " + Name +".\n The student is " + Age + " old"+ ".\nIs the student studying? " + IsStudent + ".\nThe student have any pets? " + HavePets;
    }
}