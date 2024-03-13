using MinaSidor.Server.Models.Boostning;    
namespace MinaSidor.Server.Models
    {

    public class Estate
        {
        public int Id { get; set; } 
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
