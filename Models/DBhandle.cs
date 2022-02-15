namespace Assesment_QW.Models
{
    public class DBhandle
    {
        public List<Customer> getAllRecords()
        {
            EFDBhandle context = new EFDBhandle();
            List<Customer> listP = context.Customer_TB.ToList();
            return listP;
        }


        public void AddCustomer(Customer c)
        {
            EFDBhandle context = new EFDBhandle();
            c.CreateDate = DateTime.Now;
            context.Customer_TB.Add(c);
            context.SaveChanges();
            return;


        }


        public void deleteCustomer(int id)
        {
            EFDBhandle context = new EFDBhandle();
            Customer cus = context.Customer_TB.Find(id);
            context.Customer_TB.Remove(cus);
            context.SaveChanges();
            return;


        }


        public Customer getCustomerOnId(int id)
        {
            EFDBhandle context = new EFDBhandle();

            var cus = context.Customer_TB.Find(id);
            context.SaveChanges();

            return cus;
        }


        public String updateCustomer(Customer c)
        {
            try
            {
                EFDBhandle context = new EFDBhandle();
                Customer cus = context.Customer_TB.Find(c.CustomerId);
                cus.FirstName = c.FirstName;
                cus.LastName = c.LastName;
                cus.Country = c.Country;

                context.SaveChanges();
                return "Success";
            } catch (Exception ex)
            {
                return ex.Message;
            }
           
        }



    }
}
