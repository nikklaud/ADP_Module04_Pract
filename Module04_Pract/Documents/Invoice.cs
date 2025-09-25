namespace Module04_Pract.Documents;

public class Invoice: Document
{
    public override void Open()
    {
        Console.WriteLine("Invoice opened");
    }
}