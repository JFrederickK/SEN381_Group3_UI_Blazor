using SEN381_UI.Data;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class MedicalServiceProvider
{
    private string policyProviderID;
    private string policyProviderName;
    private string policyProviderAddresses;
    private string policProviderEmail;
    private string policProviderPhone;


   public MedicalServiceProvider(string policyProviderID, string policyProviderName, string policyProviderAddresses, string policProviderEmail, string policProviderPhone)
    {
        this.policyProviderID = policyProviderID;
        this.policyProviderName = policyProviderName;  
        this.policyProviderAddresses = policyProviderAddresses;
        this.policProviderEmail = policProviderEmail;
        this.policProviderPhone = policProviderPhone;
    }
    public MedicalServiceProvider()
    {
    }

    public string PolicyProviderID { get => policyProviderID; set => policyProviderID = value; }
    [Required]
    [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
    [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = "The Name contains invalid characters.")]
    public string PolicyProviderName { get => policyProviderName; set => policyProviderName = value; }

    [Required]
    [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Wrong address format.")]
    public string PolicyProviderAddresses { get => policyProviderAddresses; set => policyProviderAddresses = value; }

    [Required]
    [EmailAddress]
    public string PolicyProviderEmail { get => policProviderEmail; set => policProviderEmail = value; }

    [Required]
    [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Invalid phone number.")]
    public string PolicProviderPhone { get => policProviderPhone; set => policProviderPhone = value; }
}