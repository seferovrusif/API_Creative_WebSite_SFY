namespace SFY.Core.Entities
{
    public class Size : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
        public IEnumerable<Bag> Bag_Handles { get; set; }
    }
}
