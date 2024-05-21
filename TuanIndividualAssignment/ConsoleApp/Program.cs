// See https://aka.ms/new-console-template for more information
using System.Text;
namespace ConsoleApp
{
    class Program
    {
        class Test
        {
            public class MainApp()
            {
                public static void Main()
                {
                    Client client = new Client();
                    DocumentBuilder builder;

                    builder = new Normal();
                    client.newDocument(builder);
                    builder.Document.Show();

                    builder = new Confidential();
                    client.newDocument(builder);
                    builder.Document.Show();

                    Console.ReadKey();
                }
            }

            class Client
            {
                public void newDocument(DocumentBuilder builder)
                {
                    builder.SetExtention();
                    builder.SetEncryption();
                }
            }

            abstract class DocumentBuilder
            {
                protected Document document;

                public Document Document
                {
                    get { return document; }
                }

                public abstract void SetExtention();
                public abstract void SetEncryption();
            }

            class Normal : DocumentBuilder
            {
                public Normal()
                {
                    document = new Document("Normal");
                }

                public override void SetExtention()
                {
                    document["Extention"] = ".txt";
                }

                public override void SetEncryption()
                {
                    document["Encryption"] = "Any Encryption";
                }

            }

            class Confidential : DocumentBuilder
            {
                public Confidential()
                {
                    document = new Document("Confidential");
                }

                public override void SetExtention()
                {
                    document["Extention"] = ".zip";
                }

                public override void SetEncryption()
                {
                    document["Encryption"] = "AES Encryption";
                }

            }

            class Document
            {
                private string _documenType;
                private Dictionary<string, string> _document = new Dictionary<string, string>();

                public Document(string DocumenType)
                {
                    this._documenType = DocumenType;
                }

                public string this[string key]
                {
                    get { return _document[key]; }
                    set { _document[key] = value; }
                }

                public void Show()
                {
                    Console.WriteLine("\n---------------------------");
                    Console.WriteLine("Document Type: {0}", _documenType);
                    Console.WriteLine(" Extention: {0}", _document["Extention"]);
                    Console.WriteLine(" Encryption: {0}", _document["Encryption"]);
                }
            }
        }
    }
}
