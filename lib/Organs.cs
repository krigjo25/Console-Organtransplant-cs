namespace Organtransplant.lib;

public class Organs
{
    
    private string _name;
    private string _type;
    private string _bloodType;
    
    private protected string Name 
    {   
        get => _name;
        set => _name = value;
    }

    private string Type
    {
        get => _type;
        set => _type = value;
    }

    private string BloodType
    {
        get => _bloodType;
        set
        {
            string[] bt = ["A", "B", "AB", "O"];

            foreach (var element in bt)
            {
                if (element == value)
                {
                    _bloodType = value;
                }
                else
                {
                    throw new Exception("Invalid Blood Type");
                }
                
            }
        }
    }

    public Organs(string[] arg)
    {
        Name = arg[0];
        Type = arg[1];
        BloodType = arg[2];
        
    }
    

    
}