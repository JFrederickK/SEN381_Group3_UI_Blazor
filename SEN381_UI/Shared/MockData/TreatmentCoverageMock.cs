using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class TreatmentCoverageMock
    {
        public List<TreatmentCoverage> getTreatmentCoverage()
        {
            return new List<TreatmentCoverage>()
            {
                new TreatmentCoverage(new Treatment_Mock().GetTreatments()[0], new CoverageMock().GetCoverages()[0]),
                new TreatmentCoverage(new Treatment_Mock().GetTreatments()[1], new CoverageMock().GetCoverages()[1]),
                new TreatmentCoverage(new Treatment_Mock().GetTreatments()[2], new CoverageMock().GetCoverages()[2]),
                new TreatmentCoverage(new Treatment_Mock().GetTreatments()[3], new CoverageMock().GetCoverages()[3]),
                new TreatmentCoverage(new Treatment_Mock().GetTreatments()[2], new CoverageMock().GetCoverages()[2]),
            };
        }
    }
}
