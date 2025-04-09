namespace SFY.Core.Entities
{
    public class Material : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
        public IEnumerable<Bag> Bag_Handles { get; set; }

    }
}
