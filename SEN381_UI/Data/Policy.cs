namespace SEN381_UI.Data;

public class Policy
{
    private string policyId = "";
    private string policyName = "";
    private string policyStatus = "";
    private List<Package> package = new List<Package>();

    public Policy(string policyId, string policyName, string policyStatus, List<Package> package)
    {
        PolicyId = policyId;
        PolicyName = policyName;
        PolicyStatus = policyStatus;
        Package = package;
    }
    public Policy()
    {

    }

    public string PolicyId { get => policyId; set => policyId = value; }
    public string PolicyName { get => policyName; set => policyName = value; }
    public string PolicyStatus { get => policyStatus; set => policyStatus = value; }
    public List<Package> Package { get => package; set => package = value; }
}