namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    public abstract class RequestCreator
    {
        public abstract IRequest CreateRequest();
        public IRequest processRequest() {
            IRequest request = this.CreateRequest();
            return request;
        }
    }
}
