using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Common.Utilities.Interceptors;

namespace Common.Aspects.Autofac.Exception
{
    public class ExceptionLogAspect : MethodInterception
    {
        public ExceptionLogAspect()
        {

        }
        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            Console.WriteLine(e.Message);
            base.OnException(invocation, e);
        }
    }
}
