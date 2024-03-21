namespace Core.Models.UserModels
    {
    public class Organization
        {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Office> Offices { get; set; }
        }
    }
