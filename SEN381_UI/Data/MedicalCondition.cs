namespace SEN381_UI.Data
{
    public class MedicalCondition
    {
        int medicalConditionID;
        string medicalConditionName;
        string medicalConditionDescription;

        public MedicalCondition()
        {


        }

        public MedicalCondition(int medicalConditionID, string medicalConditionName, string medicalConditionDescription)
        {
            this.medicalConditionID = medicalConditionID;
            this.medicalConditionName = medicalConditionName;
            this.medicalConditionDescription = medicalConditionDescription;


        }

        public int MedicalConditionID { get => medicalConditionID; set => medicalConditionID = value; }
        public string MedicalConditionName { get => medicalConditionName; set => medicalConditionName = value; }
        public string MedicalConditionDescription { get => medicalConditionDescription; set => medicalConditionDescription = value; }

        public override bool Equals(object? obj)
        {
            return obj is MedicalCondition condition &&
                   medicalConditionID == condition.medicalConditionID &&
                   medicalConditionName == condition.medicalConditionName &&
                   medicalConditionDescription == condition.medicalConditionDescription;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(medicalConditionID, medicalConditionName, medicalConditionDescription);
        }
    }
}

