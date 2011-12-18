namespace Restaurant.DTO
{
    public class ReceiptDto : BaseDto
    {
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }
        public decimal Price { get; set; }
        public float Qty { get; set; }
        public float Discount { get; set; }
        public string Comment { get; set; }

#if SILVERLIGHT   
#else
        public static ReceiptDto ToDto(BusinessLayer.ProductOrder rec)
        {
            return new ReceiptDto
                       {
                           IdProduct = rec.Id_product,
                           IdOrder = rec.Id_order,
                           Price = rec.Price,
                           Qty = rec.Quantity,
                           Discount = rec.Discount,
                           Comment = rec.Comment
                       };
        }

        public static BusinessLayer.ProductOrder FromDto(ReceiptDto receipt)
        {
            return new BusinessLayer.ProductOrder
                       {
                           Id_order = receipt.IdOrder,
                           Id_product = receipt.IdProduct,
                           Price = receipt.Price,
                           Quantity = receipt.Qty,
                           Discount = receipt.Discount,
                           Comment = receipt.Comment
                       };
        }
#endif
    }
}
