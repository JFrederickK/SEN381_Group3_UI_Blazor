namespace SEN381_UI.Data
{
    public class MedicalProviderMock
    {
        public List<MedicalServiceProvider> GetMedicalServiceProviders() { 
        List<MedicalServiceProvider> services = new List<MedicalServiceProvider>();
            services.Add(new MedicalServiceProvider("1", "Discovery", "Brakpan", "Discovery@gmail.com", "1234567891"));
            services.Add(new MedicalServiceProvider("2", "Disvery", "Brakpan", "Discovery@gmail.com", "1234567891"));
            services.Add(new MedicalServiceProvider("3", "Discvery", "Brakpan", "Discovery@gmail.com", "1234567891"));
            services.Add(new MedicalServiceProvider("4", "Dcovery", "Brakpan", "Discovery@gmail.com", "1234567891"));
            services.Add(new MedicalServiceProvider("5", "Disvery", "Brakpan", "Discovery@gmail.com", "1234567891"));

            return services;
        }
    }
}
