using System.ComponentModel.DataAnnotations;

namespace Core.Models.shared
    {
    public class ContactInformation
        {
        [Key]
        public int ContactInformationId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string WorkPhone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string WebPage { get; set; } = string.Empty;


        }
    }
