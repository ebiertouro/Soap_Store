namespace SemesterProject
{
    partial class DataClasses1DataContext
    {
        public void InsertInvoices(Invoice newInvoice)
        {
            this.Invoices.InsertOnSubmit(newInvoice);
            this.SubmitChanges();
        }
    }
}