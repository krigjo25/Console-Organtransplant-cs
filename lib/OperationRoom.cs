namespace Organtransplant.lib;

public class OperationRoom : Organs, PatientData
{
    List<Organs> AvailableOrgans = [];
    List<PatientData> patients = [];

    protected OperationRoom()
        {

            InitializeOrgrans(new Organs(organs));
            PrintOperation();
            
        }
        

        private void Transplant_organs()
        {
            // Transplant the organs
        }
        private void InitializePatient(PatientData patient)
        {
            // Initialize the patient
            patients.Add(patient);
        }
        private void InitializeOrgrans(Organs orgran)
        {
            // Initialize the orgran
            AvailableOrgans.Add(orgran);
        }
        public void PrintOperation()
        {
            
            // Print the operation
         
        }

}