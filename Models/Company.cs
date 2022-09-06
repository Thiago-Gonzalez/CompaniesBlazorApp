namespace CompaniesBlazorApp.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public void GenerateNewId() {
            Id = Guid.NewGuid();
        }
    }
}