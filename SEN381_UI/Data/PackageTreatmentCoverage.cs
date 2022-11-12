namespace SEN381_UI.Data
{
    public class PackageTreatmentCoverage
    {
        private Treatment? treatment;
        private Coverage? coverage;

        public PackageTreatmentCoverage(Treatment treatment, Coverage coverage)
        {
            this.treatment = treatment;
            this.coverage = coverage;
        }

        public Treatment Treatment { get => treatment; set => treatment = value; }
        public Coverage Coverage { get => coverage; set => coverage = value; }
    }
}
