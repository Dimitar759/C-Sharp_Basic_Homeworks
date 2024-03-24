namespace ConsoleApp1
{
    public class Trainer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Trainer()
        {
            
        }
        public Trainer(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}