using Module04_Pract.Documents;

namespace Module04_Pract.Creator;

public class ReportCreator: DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Report();
    }
}