// See https://aka.ms/new-console-template for more information

using System.Data;
using Module04_Pract.Creator;
using Module04_Pract.Documents;

namespace Module04_Pract;


internal class Program
{
    public static void Main(string[] args)
    {
        DocumentCreator[] creators = new DocumentCreator[]
        {
            new ReportCreator(), new ResumeCreator(), new LetterCreator()
        };

        foreach (DocumentCreator creator in creators)
        {
            Document document = creator.CreateDocument();
            document.Open();
        }

        while (true)
        {
            string itemType = Console.ReadLine();
            if (itemType == "work")
            {
                ToDoCreator factory = new WorkToDoCreator();
                ITodItem workItem = factory.CreateToDoItem("", DateTime.Now);
            }
        }
        
    }
}