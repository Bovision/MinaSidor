namespace MinaSidor.Server.Models.UserModels
    {
    public class Organization
        {
        public int OrganizationId { get; set; }

        public string Name { get; set; }

        public List<Office> Offices { get; set; }
        }
    }
