using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuanIndividualAssignment.Models
{
    public class Property
    {
        [Key]
        public int PropertyID { get; set; }
        public string Description { get; set; }
        [ForeignKey("PropertyOwner")]
        public int PropertyOwnerID { get; set; }
    }
}
