namespace Uper.Model
{
    public class AppUser 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Role
        {
            get; set;
        }
    }
}