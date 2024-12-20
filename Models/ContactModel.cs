namespace AuthSystem.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int? UserId { get; set; }
        public UserModel User { get; set; }
    }
}
