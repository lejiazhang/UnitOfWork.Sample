using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork.Sample.IoC.DependencyResolution
{
    /// <summary>
    /// The structure map dependency resolver.
    /// </summary>
    //public class StructureMapWebApiDependencyResolver : StructureMapWebApiDependencyScope, IDependencyResolver
    //{
    //    #region Constructors and Destructors

    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="StructureMapWebApiDependencyResolver"/> class.
    //    /// </summary>
    //    /// <param name="container">
    //    /// The container.
    //    /// </param>
    //    public StructureMapWebApiDependencyResolver(IContainer container)
    //        : base(container)
    //    {
    //    }

    //    #endregion

    //    #region Public Methods and Operators

    //    /// <summary>
    //    /// The begin scope.
    //    /// </summary>
    //    /// <returns>
    //    /// The System.Web.Http.Dependencies.IDependencyScope.
    //    /// </returns>
    //    public IDependencyScope BeginScope()
    //    {
    //        IContainer child = this.Container.GetNestedContainer();
    //        return new StructureMapWebApiDependencyResolver(child);
    //    }

    //    #endregion
    //}
}
