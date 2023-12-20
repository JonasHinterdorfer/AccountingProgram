using System.ComponentModel.DataAnnotations;

namespace Database.Data;

public class InvoiceType
{
    public int Id { get; private set; }
    public required string Name { get; init; }
    private uint _nextInvoiceId = 0;
    public uint GetNextNumber()
    {
        _nextInvoiceId++;
        return _nextInvoiceId;
    }
    
}