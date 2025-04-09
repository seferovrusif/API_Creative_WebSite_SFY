using SFY.Business.Repositories.Interfaces;
using SFY.Core.Entities;
using SFY.DAL.Contexts;

namespace SFY.Business.Repositories.Implements
{
    public class SizeRepository : GenericRepository<Size>, ISizeRepository
    {
        public SizeRepository(SFYTestContext context) : base(context)
        {
        }

 
    }
}
