namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public class LowPriorityConcreteCreator: RequestCreator
    {
        public override IRequest CreateRequest()
        {
            IRequest request = new LowPriorityConcrete();
            request.SetPriority();
            request.SetExpire();
            request.SetStatus();
            return request;
        }
    }
}
