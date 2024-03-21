using Core.Models.shared;
using Core.Models.Boostning;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.User
{
    public class Agent
        {
        [Key]
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
        [Key]
        public string id { get; set; }
        [ForeignKey("Agent")]
        public string officeId { get; set; }
        [ForeignKey("Office")]
        public string customerId { get; set; }
    }


}
