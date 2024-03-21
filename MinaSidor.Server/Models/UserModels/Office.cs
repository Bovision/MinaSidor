using MinaSidor.Server.Models.shared;
using MinaSidor.Server.Models.User;

namespace MinaSidor.Server.Models.UserModels
    {
    public class Office
        {
        public string officeId { get; set; }
        public int OrganizationId { get; set; }
        public AddressModel Address { get; set; }
        public ContactInformation contactInformation { get; set; }
        public DateTime changedAt { get; set; }
        public string corporateName { get; set; }
        public string corporateNumber { get; set; }
        public string logotype { get; set; }
        public int organizationId { get; set; }
        public string organizationName { get; set; }
        public List<Agent> agents { get; set; }
        }
    }


