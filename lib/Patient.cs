using System.Text.RegularExpressions;

namespace Organtransplant.lib;

public class Patient : DataCollection
{
    // class variables 
    private long _nin;
    private char _gender;
    private string _name;
    private string _btype;
    private bool _donor;
    private bool _hospitalized;
    
    
    public long NIN {get => _nin; set => _nin = value; }
    public string Name {get => _name; set => _name = value; }
    public string BloodType
    {
        get => _btype;
        set
        {
            //  Blood type accepts A or B  or 0 with + or - 
            const string match = @"^([AB0][\+|-])|(A+B[\+|2-])$";
            Regex rgx = new(match);

            if (rgx.IsMatch(value))
            {
                _btype = value;
            }
        }
    }
    public char Gender {get => _gender; set => _gender = value; }
    public bool IsDonor 
    {
        get => _donor;
        set => _donor = value;
    }

    public bool Hospitalized
    {
        get => _hospitalized;
        set => _hospitalized = value;
    }

    public Patient(string name, char gender, string nin, bool hospitalized = false)
    {
        var r = new Random();
        
        Name = name;
        Gender = gender;
        NIN = long.Parse(nin);
        Hospitalized = hospitalized;
        BloodType = InitializeBloodType();
        IsDonor = (0 != r.Next(0, 2));
        
        PushDonorData(this);
    }

    private void MustTransplant()
    {
        // Do something
    }
    private string InitializeBloodType()
    {
        var r = new Random();
        string[] arg = ["A+", "A-", "B+", "B-", "AB+", "AB-", "0-", "0+"];
        
        return arg[r.Next(0, arg.Length-1)];
    }
}
