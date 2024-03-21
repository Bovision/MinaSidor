using MinaSidor.Server.Models.shared;

namespace MinaSidor.Server.Models.User
{
    public class Agent
        {
        public string customerId { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;   
        public string lastName { get; set; } = string.Empty;
        public ContactInformation contactInformation { get; set; }
        public AddressModel address { get; set; }   
        public bool isAdmin { get; set; }
        public DateTime changedAt { get; set; }
        public List<Officeaffiliation> officeAffiliations { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
    }




    public class Officeaffiliation
    {
        public string officeId { get; set; }
        public string customerId { get; set; }
    }


}
