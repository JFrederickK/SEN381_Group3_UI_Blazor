using SEN381_API_Group3.shared.models;

namespace SEN381_UI.Data
{
    public class TreatmentMock
    {
        public List<Treatment> GetTreatments() { 
        List<Treatment> treatments = new List<Treatment>();
            treatments.Add(new Treatment("1", "Covid", "Help kill covid", "2"));
            return treatments;
        }
    }
}
