using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class TreatmentMock
    {
        public List<Treatment> GetTreatments()
        {
            List<Treatment> treatments = new List<Treatment>();
            treatments.Add(new Treatment("1", "Covid", "Help kill covid", new MedicalProviderMock().GetMedicalServiceProviders()));
            return treatments;
        }
    }
}
