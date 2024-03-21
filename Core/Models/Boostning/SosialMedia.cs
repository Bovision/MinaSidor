namespace Core.Models.Boostning
    {
    public class SosialMedia
    {
        public int EstateId { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SosialMediaType> MediaType { get; set; }
        public List<BostType> Type { get; set; }
    }
}
