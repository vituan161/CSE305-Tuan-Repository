namespace TuanIndividualAssignment.Models
{
    public class Tenant
    {
        public int TenantID { get; set; }
        public ICollection<RentalContract> Contracts { get; set; }
    }
}
