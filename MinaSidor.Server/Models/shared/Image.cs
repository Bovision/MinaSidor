namespace MinaSidor.Server.Models.shared
    {
    public class Image
        {
        public string id { get; set; }
        public DateTime dataChangedAt { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string tags { get; set; }
        public string extension { get; set; }
        public string url { get; set; }

        }
    }
