namespace Database.Data;

public class Invoice
{
    private uint _number = 0;
    public int Id { get; set; }
    public required InvoiceType Type { get; init; }
    public required string FilePath { get; init; }

    public uint Number
    {
        get
        {
            if (_number == 0)
                _number = this.Type.GetNextNumber();
            return _number;
        }
    }



}