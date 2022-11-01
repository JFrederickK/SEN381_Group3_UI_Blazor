using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class Treatment_Mock
    {
        public List<Treatment> GetTreatments()
        {
            List<Treatment> result = new List<Treatment>();

            result.Add(new Treatment("1", "temp1", "desctiption", new List<MedicalServiceProviderTreatment>()));
            result.Add(new Treatment("2", "temp2", "desctiption", new List<MedicalServiceProviderTreatment>()));
            result.Add(new Treatment("3", "temp3", "desctiption", new List<MedicalServiceProviderTreatment>()));
            result.Add(new Treatment("4", "temp4", "desctiption", new List<MedicalServiceProviderTreatment>()));
            return result;
        }
    }
}
