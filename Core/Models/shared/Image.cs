using System.ComponentModel.DataAnnotations;

namespace Core.Models.shared
    {
    public class Image
        {
        [Key]
        public int Id { get; set; }
        public DateTime dataChangedAt { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string tags { get; set; }
        public string extension { get; set; }
        public string url { get; set; }

        }
    }
