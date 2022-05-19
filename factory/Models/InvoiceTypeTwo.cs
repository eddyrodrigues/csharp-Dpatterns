namespace Models{
    public class InvoiceTypeTwo: Invoice {
        public string InvoiceNumber {get; set;}
        public int InvoiceCode { get; set; }
        public InvoiceTypeTwo(string invoiceNumber, int invoiceCode)
        {
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceCode = invoiceCode;
        }

        public string ListCosts(){
            return "costs 1 and 2";
        }
    }
}