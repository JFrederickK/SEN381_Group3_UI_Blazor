using System.ComponentModel.DataAnnotations;

namespace SEN381_UI.Data
{
    public class InsertMedicalConditionRequest
    {
        string name;
        string description;
        List<string> IDs;
        int counts;
        public InsertMedicalConditionRequest()
        {

        }
        public InsertMedicalConditionRequest(string name, string description, List<string> iDs, int counts)
        {
            this.Name = name;
            this.Description = description;
            IDs1 = iDs;
            this.Counts = counts;
        }
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = "The Name contains invalid characters.")]
        public string Name { get => name; set => name = value; }
        [Required]
        [StringLength(50, ErrorMessage = "Description length can't be more than 100.")]
        public string Description { get => description; set => description = value; }
        public List<string> IDs1 { get => IDs; set => IDs = value; }
        public int Counts { get => counts; set => counts = value; }
    
}
}
