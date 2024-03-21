using Core.Models.shared;
using Core.Models.Boostning;
using Core.Models.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.UserModels
{
    public class Office
        {
        [Key]   
        public string officeId { get; set; }
        public AddressModel Address { get; set; }
        public ContactInformation contactInformation { get; set; }
        public DateTime changedAt { get; set; }
        public string corporateName { get; set; }
        public string corporateNumber { get; set; }
        public string logotype { get; set; }
        [ForeignKey("Organization")]
        public int organizationId { get; set; }
        public string organizationName { get; set; }
        public List<Agent> agents { get; set; }
        }
    }


