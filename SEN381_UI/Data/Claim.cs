namespace SEN381_API_Group3.shared.models;

public class Claim
{

    public string ClaimID { get; set ; }
    public string Client { get ; set ; }
    public string MedicalConditions { get ; set ; }
    public string PlaceOfTreatment { get ; set ; }
    public string? CallDetails { get; set ; }
    public string ClaimeStatus { get ; set ; }

}