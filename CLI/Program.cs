using Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CLI;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<DataContext>(options =>
                options.UseMySQL($"Server=localhost;Database=Accounting;{Secrets.PASSWDANDUSER}Port=3306;"))
            .BuildServiceProvider();
        // Resolve the DbContext from the container
        using (var dbContext = serviceProvider.GetRequiredService<DataContext>())
        {
            foreach (var account in dbContext.Accounts)
            {
                Console.WriteLine(account.Name);
            }


            dbContext.SaveChanges();
        }
    }
}