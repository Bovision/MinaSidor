namespace MinaSidor.Server.Models.User
{
    public class Agent
    {
        public string id { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public bool isAdmin { get; set; }
        public DateTime changedAt { get; set; }
        public Telephone telephone { get; set; }
        public List<Officeaffiliation> officeAffiliations { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
    }

    public class Telephone
    {
        public object work { get; set; }
        public string cell { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public DateTime dataChangedAt { get; set; }
        public object description { get; set; }
        public object name { get; set; }
        public string category { get; set; }
        public object tags { get; set; }
        public string extension { get; set; }
        public string url { get; set; }

    }

    public class Officeaffiliation
    {
        public string officeId { get; set; }
        public string customerId { get; set; }
    }


}
