namespace Models{
    public class InvoiceTypeOne: Invoice {
        public string InvoiceNumber {get; set;}
        public int InvoiceCode { get; set; }
        public InvoiceTypeOne(string invoiceNumber, int invoiceCode)
        {
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceCode = invoiceCode;
        }
        public string ListCosts(){
            return "Costs of Invoice Type One!";
        }//teste
    }
}