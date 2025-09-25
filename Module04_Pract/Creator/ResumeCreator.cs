using Module04_Pract.Documents;

namespace Module04_Pract.Creator;

public class ResumeCreator: DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Resume();
    }
}