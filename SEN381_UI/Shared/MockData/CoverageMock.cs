using SEN381_UI.Data;

namespace SEN381_UI.Shared.MockData
{
    public class CoverageMock
    {
        public List<Coverage> GetCoverages()
        {
            List<Coverage> coverages = new List<Coverage>();
            coverages.Add(new Coverage(1, "Gold", 1, 2, 4));
            coverages.Add(new Coverage(2, "Silver", 1, 2, 5));
            coverages.Add(new Coverage(3, "Platinum", 4, 2, 6));
            coverages.Add(new Coverage(4, "Gold", 1, 5, 4));
            return coverages;
        }
    }
}
