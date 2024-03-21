namespace Core.Models
{
    public class Leads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int EstateId { get; set; }


    }
}