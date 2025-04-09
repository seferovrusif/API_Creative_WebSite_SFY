using SFY.Business.Repositories.Interfaces;
using SFY.Core.Entities;
using SFY.DAL.Contexts;

namespace SFY.Business.Repositories.Implements
{
    public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(SFYTestContext context) : base(context)
        {
        }
    }
}
