using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using CommonServiceLocator;

namespace UnitOfWork.Sample.IoC.DependencyResolution
{
    //public class StructureMapDependencyScope : ServiceLocatorImplBase
    //{
    //    #region Constants and Fields

    //    private const string NestedContainerKey = "Nested.Container.Key";

    //    #endregion

    //    #region Constructors and Destructors

    //    public StructureMapDependencyScope(IContainer container)
    //    {
    //        if (container == null)
    //        {
    //            throw new ArgumentNullException("container");
    //        }
    //        Container = container;
    //    }

    //    #endregion

    //    #region Public Properties

    //    public IContainer Container { get; set; }

    //    public IContainer CurrentNestedContainer
    //    {
    //        get
    //        {
    //            return (IContainer)HttpContext.Items[NestedContainerKey];
    //        }
    //        set
    //        {
    //            HttpContext.Items[NestedContainerKey] = value;
    //        }
    //    }

    //    #endregion

    //    #region Properties

    //    private HttpContextBase HttpContext
    //    {
    //        get
    //        {
    //            var ctx = Container.TryGetInstance<HttpContextBase>();
    //            return ctx ?? new System.Web.HttpContextWrapper(System.Web.HttpContext.Current);
    //        }
    //    }

    //    #endregion

    //    #region Public Methods and Operators

    //    public void CreateNestedContainer()
    //    {
    //        if (CurrentNestedContainer != null)
    //        {
    //            return;
    //        }
    //        CurrentNestedContainer = Container.GetNestedContainer();
    //    }

    //    public void Dispose()
    //    {
    //        if (CurrentNestedContainer != null)
    //        {
    //            CurrentNestedContainer.Dispose();
    //        }

    //        Container.Dispose();
    //    }

    //    public void DisposeNestedContainer()
    //    {
    //        if (CurrentNestedContainer != null)
    //        {
    //            CurrentNestedContainer.Dispose();
    //        }
    //    }

    //    public IEnumerable<object> GetServices(Type serviceType)
    //    {
    //        return DoGetAllInstances(serviceType);
    //    }

    //    #endregion

    //    #region Methods

    //    protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
    //    {
    //        return (CurrentNestedContainer ?? Container).GetAllInstances(serviceType).Cast<object>();
    //    }

    //    protected override object DoGetInstance(Type serviceType, string key)
    //    {
    //        IContainer container = (CurrentNestedContainer ?? Container);

    //        if (string.IsNullOrEmpty(key))
    //        {
    //            return serviceType.IsAbstract || serviceType.IsInterface
    //                ? container.TryGetInstance(serviceType)
    //                : container.GetInstance(serviceType);
    //        }

    //        return container.GetInstance(serviceType, key);
    //    }

    //    #endregion
    //}
}
