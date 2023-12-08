using Microsoft.EntityFrameworkCore;
using MvcOnlineCommercialAutomation.Models.Entities;
using System.Data;

namespace MvcOnlineCommercialAutomation.Models
{
    public class CommercialContext:DbContext
    {
        public CommercialContext(DbContextOptions<CommercialContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesTransaction> SalesTransactions { get; set; }

    }
}
