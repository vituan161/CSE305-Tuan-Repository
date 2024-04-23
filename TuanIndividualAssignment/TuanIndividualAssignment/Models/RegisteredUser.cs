using System.Collections.ObjectModel;

namespace TuanIndividualAssignment.Models
{
    public class RegisteredUser
    {
        public ICollection<User> Users { get; set; }
    }
}
