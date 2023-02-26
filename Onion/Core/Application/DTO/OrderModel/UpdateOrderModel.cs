namespace Application.DTO.OrderModel
{
    public class UpdateOrderModel
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int MovieID { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
