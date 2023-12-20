using Microsoft.EntityFrameworkCore;

namespace Database.Data;

public class Transaction
{
    public int Id { get; set; }
    public required Account Account { get; init; }
    public required decimal Amount { get; init; }


}