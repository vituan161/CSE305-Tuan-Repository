namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    internal class MediumPriorityConcreteCreator : RequestCreator
    {
        public override IRequest CreateRequest()
        {
            return new MediumPriorityConcrete();
        }
    }
}
