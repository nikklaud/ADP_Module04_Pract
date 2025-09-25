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
            Document doc = creator.CreateDocument();
            doc.Open();
        }

        // while (true)
        // {
        //     string itemType = Console.ReadLine();
        //     if (itemType == "work")
        //     {
        //         ToDoCreator factory = new WorkToDoCreator();
        //         ITodItem workItem = factory.CreateToDoItem("", DateTime.Now);
        //     }
        // }
        
        //task 3 
        Console.WriteLine("Document type (1- Letter, 2- Report, 3- Invoice, 4- Resume):");
        int choice = Convert.ToInt32(Console.ReadLine());
        DocumentCreator documentCreator = null;
        Document document = null;
        switch (choice)
        {
            case 1:
                documentCreator = new LetterCreator();
                break;
            case 2:
                
                documentCreator = new ReportCreator();
                break;
            case 3:
                documentCreator = new InvoiceCreator();
                break;
            case 4:
                documentCreator = new ResumeCreator();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
            
        }
        document = documentCreator.CreateDocument();
        document.Open();
        

    }
}