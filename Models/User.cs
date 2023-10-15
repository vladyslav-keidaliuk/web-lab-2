namespace WebLab2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? RoleId { get; set; }
        public Role? Role { get; set; } 

    }
}
