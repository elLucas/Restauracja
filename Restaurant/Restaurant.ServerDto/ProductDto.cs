namespace Restaurant.DTO
{
    public class ProductDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int IdCategory { get; set; }

#if SILVERLIGHT
#else
        public static ProductDto ToDto(BusinessLayer.Product product)
        {
            return new ProductDto
                       {
                           Id = product.Id,
                           Name = product.Name,
                           Price = product.Price,
                           IdCategory = product.Category
                       };
        }

        public static BusinessLayer.Product FromDto(ProductDto product)
        {
            return new BusinessLayer.Product
                       {
                           Id = product.Id,
                           Name = product.Name,
                           Price = product.Price,
                           Category = product.IdCategory
                       };
        }
#endif
    }
}
