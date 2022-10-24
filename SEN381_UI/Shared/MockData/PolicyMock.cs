using SEN381_UI.Data;

namespace SEN381_UI.Shared.Mock_Data
{
    public class Policy_Mock
    {
        public List<Policy> getMockPolicies()
        {
            List<Policy> lpol = new List<Policy>();

            lpol.Add(new Policy("1","Temp1","Limited",new PackageMock().getMockPackages()));
            lpol.Add(new Policy("2", "Temp2", "Limited", new PackageMock().getMockPackages()));
            lpol.Add(new Policy("3", "Temp3", "ACTIVE", new PackageMock().getMockPackages()));


            return lpol;
        }
    }
}
