using Microsoft.EntityFrameworkCore;

namespace Database.Data;

public class DataContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceType> InvoiceTypes { get; set; }
    public DbSet<Journal> Journals { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}