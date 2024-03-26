namespace images.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int price { get; set; }

        //first image will be
        public IFormFile photo { get; set; }
    }
}
