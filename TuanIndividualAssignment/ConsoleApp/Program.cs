// See https://aka.ms/new-console-template for more information
using System.Text;
using TuanIndividualAssignment.Factory_Method_Pattern;
namespace ConsoleApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            RequestCreator requestCreator = new LowPriorityConcreteCreator();
            IRequest request = requestCreator.CreateRequest();
            request.ProcessRequest();
            Console.WriteLine(request);
            Console.WriteLine("-----------------");
            requestCreator = new MediumPriorityConcreteCreator();
            request = requestCreator.CreateRequest();
            request.ProcessRequest();
            Console.WriteLine(request);
            Console.WriteLine("-----------------");
            requestCreator = new HighPriorityConcreteCreator();
            request = requestCreator.CreateRequest();
            request.ProcessRequest();
            Console.WriteLine(request);
            Console.WriteLine("-----------------");
        }
    }
}
