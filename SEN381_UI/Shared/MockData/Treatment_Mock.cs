using SEN381_API_Group3.shared.models;

namespace SEN381_UI.Shared.MockData
{
    public class Treatment_Mock
    {
        public List<Treatment> GetTreatments()
        {
            List<Treatment> result = new List<Treatment>();

            result.Add(new Treatment("1", "temp1", "desctiption", "1"));
            result.Add(new Treatment("2", "temp2", "desctiption", "1"));
            result.Add(new Treatment("3", "temp3", "desctiption", "2"));
            result.Add(new Treatment("4", "temp4", "desctiption", "5"));
            return result;
        }
    }
}
