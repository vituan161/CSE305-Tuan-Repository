// See https://aka.ms/new-console-template for more information
using TuanIndividualAssignment.Factory_Method_Pattern;

namespace ConsoleApp
{
    public class MainApp()
    {
        public static void Main(String[] args)
        {
            RequestCreator requestCreator = new LowPriorityConcreteCreator();
            IRequest request = requestCreator.CreateRequest();
            request.ProcessRequest();
            Console.WriteLine("Request Type: " + request.GetType().Name);
        }
    }
}
