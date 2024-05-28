namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public class LowPriorityConcreteCreator: RequestCreator
    {
        public override IRequest CreateRequest()
        {
            return new LowPriorityConcrete();
        }
    }
}
