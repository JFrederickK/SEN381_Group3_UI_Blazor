namespace SEN381_UI.Data
{
    public class MedicalServiceProvider
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public MedicalServiceProvider(string v1, string v2, string v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public string PolicyProviderID { get; set; }
        public string PolicyProviderName { get; set; }
        public string PolicyProviderAddresses { get; set; }
        public string PolicyProviderEmail { get; set; }
        public string PolicProviderPhone { get; set; }
    }
}