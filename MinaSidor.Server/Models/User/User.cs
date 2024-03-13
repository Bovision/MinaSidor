namespace MinaSidor.Server.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public bool enabled { get; set; }


    }
}
