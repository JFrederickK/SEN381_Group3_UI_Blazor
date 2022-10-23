namespace SEN381_UI.Shared.MockData
{
    public class ProviderMock
    {
        public List<MedicalServiceProvider> GetMedicalServiceProviders()
        {
            List<MedicalServiceProvider> list = new List<MedicalServiceProvider>();
            list.Add(new MedicalServiceProvider("1", "Discovery", "23 Valintine", "Discovery@gmail.com", "1234567891"));
            list.Add(new MedicalServiceProvider("1", "Discovery", "23 Valintine", "Discovery@gmail.com", "1234567891"));
            list.Add(new MedicalServiceProvider("1", "Discovery", "23 Valintine", "Discovery@gmail.com", "1234567891"));
            list.Add(new MedicalServiceProvider("1", "Discovery", "23 Valintine", "Discovery@gmail.com", "1234567891"));
            list.Add(new MedicalServiceProvider("1", "Discovery", "23 Valintine", "Discovery@gmail.com", "1234567891"));
            return list;
        }
    }
}
