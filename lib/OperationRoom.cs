using System.Linq.Expressions;

namespace Organtransplant.lib;

public class DataCollection
{
    private readonly List<Patient> PatientsData = [];
    
    private readonly List<Patient> _donorData = [];
    private readonly List<Organ> _availableOrgans = [];

    protected void PushDonorData(Patient donorData)
    {
        _donorData.Add(donorData);
    }

    protected void PushPatientData(Patient patient)
    {
        PatientsData.Add(patient);
    }
    protected void PushOrgansData(Organ organsData)
    {
        _availableOrgans.Add(organsData);
    }

    public void PrintDonorList()
    {
        Console.Clear();
        Console.WriteLine("Available Donors:");
        foreach (var donor in _donorData)
        {
            if (donor.IsDonor & !donor.Hospitalized)
            {
                
                Console.WriteLine($"Name : {donor.Name}, BloodType: {donor.BloodType}");
            }
        }
    }
    
    public void PrintPatient()
    {
        Console.Clear();
        Console.WriteLine("Patient :");
        foreach (var donor in _donorData)
        {
            if (donor.Hospitalized)
            {
                
                
                Console.WriteLine($"Name : {donor.Name}, NationalID : {donor.NIN}, BloodType: {donor.BloodType}");
            }
        }
    }
   
    public void PrintAvailableOrgans()
    {
        Console.Clear();
        Console.WriteLine("Available Organs:");

        foreach (var organ in _availableOrgans)
        {
            
            Console.WriteLine($"Organ : {organ.Name}, BloodType: {organ.BloodType}");
        }
    }

    public void ReplayTranslpant()
    {
        Console.Clear();
        Console.WriteLine("A simulation of an Orgran Translpant");
        // Simulate an operation
        
        Patient patient = null;

        foreach (var donor in _donorData)
        {
            
            if (donor.Hospitalized)
            {
                patient = donor;
            }
            
        }
        foreach (var donor in _donorData)
        {
            if (!donor.Hospitalized && donor.IsDonor && Organ.BloodTypeMatch(donor.BloodType, patient.BloodType))
            {
                Console.WriteLine($"Matching Donor : {donor.Name}, BloodType: {donor.BloodType}");
            }
            
        }
        

    }
    

    public void InitializeDonorData()
    {
        var r = new Random();

        string[] arg = ["03071977", "03061957", "8191970", "02051992", "18111963", "14092009", "15081961", "28041983"];
        _donorData.Add(new Patient("Leslie H Burke", 'F', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Tina D Woodcock", 'F', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Ernesto S Sparrow", 'M', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Roger I. Dreyer", 'M', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Erling Brenna", 'M', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Iris Pedersen", 'F', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Hana Brattli", 'F', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}"));
        _donorData.Add(new Patient("Max Østlie", 'M', $"{arg[r.Next(arg.Length)]}{r.Next(1000, 9999)}", true));
    }

    public void InitalizeOrganData()
    {
        var r = new Random();
        string[] arg = ["Heart", "kidney", "Brain", "Stomack"];
        string[] bt = ["A+", "A-", "AB+", "AB-", "B+", "B-", "O-", "O+"];
        foreach (var element in arg)
        {
            
            _availableOrgans.Add(new Organ(element, bt[r.Next(bt.Length-1)]));
        }
    }
    
}
    