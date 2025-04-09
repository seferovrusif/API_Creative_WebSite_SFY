namespace SFY.Core.Entities.Common
{
    public class BaseEntity
    {
        public int id { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual DateTime UpdatedTime { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
