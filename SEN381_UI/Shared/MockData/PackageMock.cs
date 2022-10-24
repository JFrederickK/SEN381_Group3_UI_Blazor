using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class PackageMock
    {
        public List<Package> getPackages()
        {
            return new List<Package>()
            {
                new Package("0",new TreatmentCoverageMock().getTreatmentCoverage()),
                new Package("1",new TreatmentCoverageMock().getTreatmentCoverage()),
                new Package("2",new TreatmentCoverageMock().getTreatmentCoverage()),
                new Package("3",new TreatmentCoverageMock().getTreatmentCoverage()),
                new Package("4",new TreatmentCoverageMock().getTreatmentCoverage())
            };
        }
    }
}
