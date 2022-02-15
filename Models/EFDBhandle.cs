using Microsoft.EntityFrameworkCore;

namespace Assesment_QW.Models
{
    public class EFDBhandle : DbContext
    {

        public string conn = "Server=LAPTOP-PR9IVP16;Database=CodeFirst_CustomerDB;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }


        public DbSet<Customer> Customer_TB{ get; set; }
       


    }
}
