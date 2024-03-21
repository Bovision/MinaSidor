using Core.Models.Boostning;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{

    public class Estate
        {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Office")]
        public string officeId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Type { get; set; }

        public int Price { get; set; }  

        public DateTime lastvisit { get; set; }

        public int Leadcount { get; set; }

        public List<Leads> leads { get; set; }

        public int views { get; set; }

        public string image { get; set; }

        public string url { get; set; }

        public List<Boost> boost { get; set; }  
        public Estate() { }

        }
    }
