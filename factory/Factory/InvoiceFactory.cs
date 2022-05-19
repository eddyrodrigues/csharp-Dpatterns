using Models;
// dudu
namespace Factory{
    public class InvoiceFactory{
        public Invoice createInvoice(string invoice__number, int invoice__code){
            if (invoice__code == 1)
                return new InvoiceTypeOne(invoice__number, invoice__code);
            return new InvoiceTypeTwo(invoice__number, invoice__code);
        }
    }
}