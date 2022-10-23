namespace SEN381_UI.Data
{
    public class CoverageMock
    {
        public List<TreatmentCoverage> GetCoverages() {
            List<TreatmentCoverage> coverages = new List<TreatmentCoverage>();
            coverages.Add(new TreatmentCoverage(1, "Gold", 1,2,4));
            coverages.Add(new TreatmentCoverage(2, "Silver", 1, 2, 5));
            coverages.Add(new TreatmentCoverage(3, "Platinum", 4, 2, 6));
            coverages.Add(new TreatmentCoverage(4, "Gold", 1, 5, 4));
            return coverages; 
        }
    }
}
