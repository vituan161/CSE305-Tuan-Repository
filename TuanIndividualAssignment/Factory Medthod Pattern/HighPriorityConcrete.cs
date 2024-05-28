namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public class HighPriorityConcrete : IRequest
    {
        public string priority { get; set; }
        public string expireDay { get; set; }
        public string status { get; set; }

        public void SetPriority()
        {
            priority = "Emergency";
        }

        public void SetExpire()
        {
            expireDay = DateTime.Today.ToString();
        }

        public void SetStatus()
        {
            status = "Accept";
        }

        public void ProcessRequest()
        {
            Console.WriteLine("Emergency request, our Administer will contact you immediately ");
        }
    }
}
