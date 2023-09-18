using System;

namespace _20_09
{
    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }

    class ProDocumentProgram : DocumentProgram
    {
        public new void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }

        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        
    }

    class ExpertDocument : ProDocumentProgram
    {
        public new void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public new void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public new void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("(basic - pro - expert) 3den 1ni daxil edin: ");
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "BASIC")
            {
                DocumentProgram docProgram = new DocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else if (choice.ToUpper() == "PRO")
            {
                DocumentProgram docProgram = new ProDocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else if (choice.ToUpper() == "EXPERT")
            {
                DocumentProgram docProgram = new ExpertDocument();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else
            {
                return;
            }
        }
    }
}