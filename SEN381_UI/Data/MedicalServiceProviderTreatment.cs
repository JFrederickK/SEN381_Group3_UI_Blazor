namespace SEN381_UI.Data
{
    public class MedicalServiceProviderTreatment
    {
        int mSPTID;
        string providerStatus;
        MedicalServiceProvider medicalServiceProvidor;

        public int MSPTID { get => mSPTID; set => mSPTID = value; }
        public string ProviderStatus { get => providerStatus; set => providerStatus = value; }
        public MedicalServiceProvider MedicalServiceProvidor { get => medicalServiceProvidor; set => medicalServiceProvidor = value; }

        public MedicalServiceProviderTreatment(int mSPTID, string providerStatus, MedicalServiceProvider medicalServiceProvidor)
        {
            this.MSPTID = mSPTID;
            this.ProviderStatus = providerStatus;
            this.MedicalServiceProvidor = medicalServiceProvidor;
        }
        public MedicalServiceProviderTreatment()
        {
        }
    }
}
