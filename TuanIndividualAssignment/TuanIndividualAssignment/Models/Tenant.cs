namespace TuanIndividualAssignment.Models
{
    public class Tenant
    {
        public int TenantID { get; set; }
<<<<<<< Updated upstream
        public ICollection<RentalContract> Contracts { get; set; }
=======
        public ICollection<RentalContract> RentalContracts { get; set; }
>>>>>>> Stashed changes
    }
}
