namespace TuanIndividualAssignment.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public enum UserType{
            admin,guess
        }
    }
}
