namespace PSSTORE.Models
{
    public class ware
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public byte[] Photo { get; set; }

    }
}
