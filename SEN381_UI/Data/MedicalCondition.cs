namespace SEN381_UI.Data
{
    public class MedicalCondition
    {
        string medicalConditionID;
        string medicalConditionName;
        string medicalConditionDescription;
        List<Treatment> treatments;

        public MedicalCondition(string medicalConditionID, string medicalConditionName, string medicalConditionDescription, List<Treatment> treatments)
        {
            this.medicalConditionID = medicalConditionID;
            this.medicalConditionName = medicalConditionName;
            this.medicalConditionDescription = medicalConditionDescription;
            this.treatments = treatments;

        }

        public string MedicalConditionID { get => medicalConditionID; set => medicalConditionID = value; }
        public string MedicalConditionName { get => medicalConditionName; set => medicalConditionName = value; }
        public string MedicalConditionDescription { get => medicalConditionDescription; set => medicalConditionDescription = value; }
        public List<Treatment> Treatments { get => treatments; set => treatments = value; }

    }
}

