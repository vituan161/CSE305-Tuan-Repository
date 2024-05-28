namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public interface IRequest
    {
        string priority { get; set; }
        string expireDay { get; set; }
        string status { get; set; }
        void SetPriority();
        void SetExpire();
        void SetStatus();
        void ProcessRequest();
    }
}
