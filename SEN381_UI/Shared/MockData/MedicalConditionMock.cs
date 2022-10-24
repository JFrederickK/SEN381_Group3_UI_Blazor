using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class MedicalConditionMock
    {
        public List<MedicalCondition> GetMedicals()
        {
            List<MedicalCondition> list = new List<MedicalCondition>();
            list.Add(new MedicalCondition("1", "Phize", "Help with phizer", new TreatmentMock().GetTreatments()));
            list.Add(new MedicalCondition("2", "Phzer", "Help with phizer", new TreatmentMock().GetTreatments()));
            list.Add(new MedicalCondition("3", "Pizer", "Help with phizer", new TreatmentMock().GetTreatments()));
            list.Add(new MedicalCondition("4", "Pher", "Help with phizer", new TreatmentMock().GetTreatments()));
            return list;
        }
    }
}
