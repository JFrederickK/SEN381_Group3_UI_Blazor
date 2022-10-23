using SEN381_API_Group3.shared.models;

namespace SEN381_UI.Shared.MockData
{
    public class MedicalConditionMock
    {
        public List<MedicalCondition> GetMedicals()
        {
            List<MedicalCondition> list = new List<MedicalCondition>();
            list.Add(new MedicalCondition("1", "Phize", "Help with phizer", "1"));
            list.Add(new MedicalCondition("2", "Phzer", "Help with phizer", "1"));
            list.Add(new MedicalCondition("3", "Pizer", "Help with phizer", "1"));
            list.Add(new MedicalCondition("4", "Pher", "Help with phizer", "1"));
            return list;
        }
    }
}
