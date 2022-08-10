namespace SimpleApi.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string CustomerName { get; set; }
        public string PurchasesProduct { get; set; }
        public string PaymentType { get; set; }

    }
}
