namespace Models{
    public interface Invoice{
        public string InvoiceNumber { get; set; }
        public int InvoiceCode { get; set; }
        
        public string ListCosts();
    }
}