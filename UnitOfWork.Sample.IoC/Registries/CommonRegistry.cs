namespace UnitOfWork.Sample.IoC.Registries
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UnitOfWork.Sample.DataAccess;
    using UnitOfWork.Sample.Domain.Services;
    public class CommonRegistry : StructureMap.Registry
    {
        public CommonRegistry()
        {
            Scan(
                scan =>
                {
                    scan.AssemblyContainingType<IArticleService>();

                    scan.WithDefaultConventions();
                });
            For<IDataProvider>().Use<DataProvider>();
        }
    }
}
