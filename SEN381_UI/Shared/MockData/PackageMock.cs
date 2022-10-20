using SEN381_API_Group3.shared.models;

namespace SEN381_UI.Shared.Mock_Data
{
    public class PackageMock
    {
        public List<Package> getMockPackages()
        {
            List<Package> packages = new List<Package>();
            packages.Add(new Package("1", "Sdsadl", "st"));
            packages.Add(new Package("2", "Sd3", "st2"));
            packages.Add(new Package("3", "S2", "st3"));
            return packages;
        }
    }
}
