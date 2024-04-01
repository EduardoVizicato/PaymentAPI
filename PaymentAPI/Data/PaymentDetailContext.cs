using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Data
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<PaymentDetailModel> PaymentDetailAPI { get; set; }
    }
}
