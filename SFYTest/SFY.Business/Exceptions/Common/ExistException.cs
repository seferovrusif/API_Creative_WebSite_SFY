using SFY.Core.Entities.Common;

namespace SFY.Business.Exceptions.Common
{
    public class ExistException<T> : Exception where T : BaseEntity
    {
        public ExistException() : base(typeof(T).Name+ " is already exist." )
        {
        }

        public ExistException(string? message) : base(message)
        {
        }
    }
}
