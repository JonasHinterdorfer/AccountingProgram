namespace Database.Data;

public class Journal
{
    public int Id { get; set; }
    public required DateTime DateTime { get; init; }
    public required Invoice Invoice { get; init; }

    public required Transaction[] Transactions { get; init; }
    

    
}
