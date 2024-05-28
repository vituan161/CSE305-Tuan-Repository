namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public class LowPriorityConcrete : IRequest
    {
        public string priority { get; set; }
        public string expireDay { get; set; }
        public string status { get; set; }

        public void SetPriority()
    {
            priority = "Ignore";
        }

        public void SetExpire()
    {
            expireDay = DateTime.Today.ToString();
        }

        public void SetStatus()
    {
            status = "Done";
        }

        public void ProcessRequest()
    {
            Console.WriteLine("Request Denied");
        }
    }
}
