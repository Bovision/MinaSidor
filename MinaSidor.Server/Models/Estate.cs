using MinaSidor.Server.Models.Boostning;
using MinaSidor.Server.Models.User;
using System.Runtime.InteropServices;
namespace MinaSidor.Server.Models
    {

    public class Estate
        {
        public int Id { get; set; }
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
        public Agent PrimaryAgent { get; set; }

        public string url { get; set; }

        public List<Boost> boost { get; set; }  

        public Estate() { }

        }
    }
