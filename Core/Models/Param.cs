namespace Service.Bvadmin.Interfaces
    {
    public class Param
        {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; } = null;
        public string? Group { get; set; }
        public int Customerid { get; internal set; }
        }
    }