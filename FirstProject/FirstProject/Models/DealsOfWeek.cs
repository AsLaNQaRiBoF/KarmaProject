namespace FirstProject.Models
{
    public class DealsOfWeek
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public int PriceAfterDiscount { get; set; }
        public int PriceBeforeDiscount { get; set; }
    }
}
