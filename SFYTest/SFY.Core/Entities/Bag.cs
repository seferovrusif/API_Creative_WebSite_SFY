namespace SFY.Core.Entities
{
    public class Bag : BaseEntity
    {
        public  string Title { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int Handle_SizeId { get; set; }
        public Size Handle_Size { get; set; }   
        public int Handle_ColorId { get; set; }
        public Color Handle_Color { get; set; }
        public int Handle_MaterialId { get; set; }
        public Material Handle_Material { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
