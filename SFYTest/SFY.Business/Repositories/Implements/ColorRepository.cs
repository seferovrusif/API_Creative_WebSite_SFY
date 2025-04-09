using SFY.Business.Repositories.Interfaces;
using SFY.Core.Entities;
using SFY.DAL.Contexts;

namespace SFY.Business.Repositories.Implements
{
    public class ColorRepository : GenericRepository<Color>, IColorRepository
    {
        public ColorRepository(SFYTestContext context) : base(context)
        {
        }
    }
}
