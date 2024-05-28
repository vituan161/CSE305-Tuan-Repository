namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    internal class MediumPriorityConcreteCreator : RequestCreator
    {
        public override IRequest CreateRequest()
        {
            IRequest request = new MediumPriorityConcrete();
            request.SetPriority();
            request.SetExpire();
            request.SetStatus();
            return request;
        }
    }
}
