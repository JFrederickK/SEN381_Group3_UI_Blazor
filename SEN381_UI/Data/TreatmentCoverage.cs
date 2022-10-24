using SEN381_UI.Data;

namespace SEN381_UI.Data
{
    public class TreatmentCoverage
    {
        Treatment treatment;
        Coverage coverage;

        public TreatmentCoverage()
        {}
        public TreatmentCoverage(Treatment treatment, Coverage coverage)
        {
            this.treatment = treatment;
            this.coverage = coverage;
        }

        public Treatment Treatment { get => treatment; set => treatment = value; }
        public Coverage Coverage { get => coverage; set => coverage = value; }
    }
}
