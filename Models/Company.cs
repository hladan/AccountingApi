namespace Accounting.Api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string TaxNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Website { get; set; } = "";
    }
}
