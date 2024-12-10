using System.Text.RegularExpressions;

namespace Organtransplant.lib;

public class Organ : DataCollection
{
    private int _sum;
    private string _name;
    private string _bloodType;


    public string Name 
    {   
        get => _name;
        set => _name = value;
    }

    public string BloodType
    {
        get => _bloodType;
        set
        {
            //  Blood type accepts A or B  or 0 with + or - 
            const string match = @"^([AB0][\+|-])|(A+B[\+|2-])$";
            Regex rgx = new(match);

            if (rgx.IsMatch(value))
            {
                _bloodType = value;
            }
        }
    }

    protected int Sum
    {
        get => _sum;
        set => _sum = value;
    }

    public Organ(string name, string bloodType, int sum = 1)
    {
        Sum = sum;
        Name = name;
        BloodType = bloodType;
        
        PushOrgansData(this);
    }

    internal bool IsPatientMatch(List<Patient> donor, List<Patient> patients)
    {
        return donor.Any(element => patients.Any(patient => patient.Name != element.Name && BloodTypeMatch(element.BloodType, patient.BloodType)));
    }

    private bool BloodTypeMatch(string arg, string arg1)
    {
        // Ensures that the BloodType Matches
        return (arg.Equals(arg1) || arg == "0-" || arg1 == "AB+");
    }
    bool IsOrganMatch()
    {
        // filter people by organ donor
        return false;
    }
    
}