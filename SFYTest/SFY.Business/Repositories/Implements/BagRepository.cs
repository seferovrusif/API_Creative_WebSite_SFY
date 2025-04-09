using SFY.Business.Repositories.Interfaces;
using SFY.Core.Entities;
using SFY.DAL.Contexts;

namespace SFY.Business.Repositories.Implements
{
    public class BagRepository : GenericRepository<Bag>, IBagRepository
    {
        public BagRepository(SFYTestContext context) : base(context)
        {
        }
    }
}
