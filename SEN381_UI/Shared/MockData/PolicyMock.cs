using MudBlazor;
using SEN381_UI.Data;
using SEN381_UI.Shared.MockData;

namespace SEN381_UI.Shared.MockData
{
    public class PolicyMock
    {
        public List<Policy> getMockPolicies()
        {
            List<Policy> lpol = new List<Policy>();

            lpol.Add(new Policy("1","Temp1","Limited", DateTime.Now.Date, DateTime.Now.AddDays(5).Date, new PackageMock().getPackages()));
            lpol.Add(new Policy("2", "Temp2", "Limited", DateTime.Now.Date, DateTime.Now.AddDays(5).Date, new PackageMock().getPackages()));
            lpol.Add(new Policy("3", "Temp3", "ACTIVE", DateTime.Now.Date, DateTime.Now.AddDays(5).Date, new PackageMock().getPackages()));


            return lpol;
        }
    }
}
