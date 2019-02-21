namespace UnitOfWork.Sample.Domain.Exceptions
{
    using System;

    public class BusinessExceptions : Exception
    {
        public BusinessExceptions(string message) : base(message)
        {

        }
    }
}
