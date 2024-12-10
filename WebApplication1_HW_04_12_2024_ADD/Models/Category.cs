namespace WebApplication1_HW_04_12_2024_ADD.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Article> Articles { get; set; }
    }
}
