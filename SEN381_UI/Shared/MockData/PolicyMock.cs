using SEN381_UI.Data;
using SEN381_UI.Shared.MockData;

namespace SEN381_UI.Shared.MockData
{
    public class PolicyMock
    {
        public List<Policy> getMockPolicies()
        {
            List<Policy> lpol = new List<Policy>();

            lpol.Add(new Policy("1","Temp1","Limited",, new PackageMock().getPackages()));
            lpol.Add(new Policy("2", "Temp2", "Limited", new PackageMock().getPackages()));
            lpol.Add(new Policy("3", "Temp3", "ACTIVE", new PackageMock().getPackages()));


            return lpol;
        }
    }
}
