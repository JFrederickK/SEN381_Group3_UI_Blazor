using MudBlazor;

namespace SEN381_UI.Data;

public class Policy
{
    private string policyId = "";
    private string policyName = "";
    private string policyStatus = "";

    private DateTime statusStartDate;
    private DateTime statusEndDate;

    private List<Package> package = new List<Package>();

    public Policy(string policyId, string policyName, string policyStatus, DateTime statusStartDate, DateTime statusEndDate, List<Package> package)
    {
        PolicyId = policyId;
        PolicyName = policyName;
        PolicyStatus = policyStatus;
        StatusStartDate = statusStartDate;
        StatusEndDate = statusEndDate;
        Package = package;
    }
    public Policy()
    {

    }

    public string PolicyId { get => policyId; set => policyId = value; }
    public string PolicyName { get => policyName; set => policyName = value; }
    public string PolicyStatus { get => policyStatus; set => policyStatus = value; }
    
    public DateTime StatusStartDate { get => statusStartDate; set => statusStartDate = value; }

    public List<Package> Package { get => package; set => package = value; }
    public DateTime StatusEndDate { get => statusEndDate; set => statusEndDate = value; }
}