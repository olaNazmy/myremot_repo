using System.ComponentModel.DataAnnotations;

namespace images.Models
{
    public class product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int price { get; set; }

        public string Image { get; set; }


    }
}
