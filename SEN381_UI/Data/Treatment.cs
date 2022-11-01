namespace SEN381_UI.Data;

public class Treatment
{
    string treatmentID;
    string treatmentName;
    string treatmentDescription;
    List<MedicalServiceProviderTreatment> medicalServiceProviderTreatments;

    public Treatment(string treatmentID, string treatmentName, string treatmentDescription, List<MedicalServiceProviderTreatment> medicalServiceProviderTreatments)
    {
        this.treatmentID = treatmentID;
        this.treatmentName = treatmentName;
        this.treatmentDescription = treatmentDescription;
        this.medicalServiceProviderTreatments = medicalServiceProviderTreatments;
    }
    public Treatment()
    {
    }

    public string TreatmentID { get => treatmentID; set => treatmentID = value; }
    public string TreatmentName { get => treatmentName; set => treatmentName = value; }
    public string TreatmentDescription { get => treatmentDescription; set => treatmentDescription = value; }
    public List<MedicalServiceProviderTreatment> MedicalServiceProviderTreatments { get => medicalServiceProviderTreatments; set => medicalServiceProviderTreatments = value; }
}