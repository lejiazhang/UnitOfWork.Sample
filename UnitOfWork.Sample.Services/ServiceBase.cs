namespace UnitOfWork.Sample.Services
{
    using UnitOfWork.Core;
    using UnitOfWork.Sample.DataAccess;

    public abstract class ServiceBase
    {
        protected IUnitOfWork<IDataProvider> _uow;

        public ServiceBase(IUnitOfWork<IDataProvider> uow)
        {
            _uow = uow;
        }
    }
}
