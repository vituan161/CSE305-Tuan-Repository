namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public class MediumPriorityConcrete: IRequest
    {
        public string priority { get; set; }
        public string expireDay { get; set; }
        public string status { get; set; }

        public void SetPriority()
        {
            priority = "Medium";
        }

        public void SetExpire()
        {
            expireDay = DateTime.Today.AddMonths(1).ToString();
        }

        public void SetStatus()
        {
            status = "Accepted";
        }

        public void ProcessRequest()
        {
            Console.WriteLine("Request accept, estimated completion date is "+expireDay);
        }
    }
}
