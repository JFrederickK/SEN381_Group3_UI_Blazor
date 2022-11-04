namespace SEN381_UI.Data
{
    public class MedicalCondition
    {
        string medicalConditionID;
        string medicalConditionName;
        string medicalConditionDescription;
        string treatments;

        public MedicalCondition(string medicalConditionID, string medicalConditionName, string medicalConditionDescription, string treatments)
        {
            this.medicalConditionID = medicalConditionID;
            this.medicalConditionName = medicalConditionName;
            this.medicalConditionDescription = medicalConditionDescription;
            this.treatments = treatments;

        }

        public string MedicalConditionID { get => medicalConditionID; set => medicalConditionID = value; }
        public string MedicalConditionName { get => medicalConditionName; set => medicalConditionName = value; }
        public string MedicalConditionDescription { get => medicalConditionDescription; set => medicalConditionDescription = value; }
        public string Treatments { get => treatments; set => treatments = value; }

    }
}

