namespace Application.DTO.OrderModel
{
    public class CreateOrderModel
    {
        public int CustomerID { get; set; }

        public int MovieID { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
