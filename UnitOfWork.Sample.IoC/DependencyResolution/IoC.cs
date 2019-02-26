namespace UnitOfWork.Sample.IoC.DependencyResolution
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using StructureMap;
    using UnitOfWork.Core;
    using UnitOfWork.Sample.DataAccess;
    using UnitOfWork.Sample.IoC.Registries;

    public static class IoC
    {
        public static Container Container { get; set; }

        public static IContainer Iniailize (params Registry[] registries)
        {
            Container = new Container(c => {

                c.AddRegistry<CommonRegistry>();

                foreach (var registry in registries)
                {
                    c.AddRegistry(registry);
                }

            });
           // Container
            return Container;
        }
    }
}
