namespace SFY.Core.Entities
{
    public class Color : BaseEntity
    {
        public string HexCode { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
        public IEnumerable<Bag> Bag_Handles { get; set; }

    }
}
