namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }

        public Pizza(int id, string name, string description, string picture, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
            Price = price;
        }
    }
}
