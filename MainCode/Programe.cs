using System;
using Autofac;
using System.Globalization;

namespace MainCode
{
    public class Programe
    {
        void Main(string[] args)
        {
            //registering interface with class that implemented
            var builder = new ContainerBuilder();
            builder.RegisterType<NumberType>().As<InumberTypes>();

            //Resolving inteface with autofac
            var container = builder.Build();
            var printService = container.Resolve<InumberTypes>();
        }
    }
}
