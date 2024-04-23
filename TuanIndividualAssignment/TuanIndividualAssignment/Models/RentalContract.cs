using System.ComponentModel.DataAnnotations.Schema;

namespace TuanIndividualAssignment.Models
{
    public class RentalContract
    {
        public int RentalContractID { get; set; }
        [ForeignKey("Property")]
        public int PropertyID { get; set; }
        [ForeignKey("Tenant")]
        public int TenantID { get; set; }
        public int RentAmount { get; set; }
    }
}
