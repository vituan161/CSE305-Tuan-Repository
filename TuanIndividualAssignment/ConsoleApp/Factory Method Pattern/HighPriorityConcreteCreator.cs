using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuanIndividualAssignment.Factory_Method_Pattern
{
    internal class HighPriorityConcreteCreator: RequestCreator
    {
        public override IRequest CreateRequest()
        {
            IRequest request = new HighPriorityConcrete();
            request.SetPriority();
            request.SetExpire();
            request.SetStatus();
            return request;
        }
    }
}
