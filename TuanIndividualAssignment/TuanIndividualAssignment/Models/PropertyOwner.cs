using System.ComponentModel.DataAnnotations;

namespace TuanIndividualAssignment.Models
{
    public class PropertyOwner
    {
        [Key]
        public int PropertyOwnerID { get; set; }
        public ICollection<Property> listProperties {  get; set; }
        
    }
}
