using System;

namespace FactoryMethodPatternExample
{
    // Product Interface
    interface IDocument
    {
        void Open();
    }

    // Concrete Products
    class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }

    class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }

    class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }

    // Factory Abstract Class
    abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }

    // Concrete Factories
    class WordFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }

    class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }

    class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory;

            factory = new WordFactory();
            IDocument word = factory.CreateDocument();
            word.Open();

            factory = new PdfFactory();
            IDocument pdf = factory.CreateDocument();
            pdf.Open();

            factory = new ExcelFactory();
            IDocument excel = factory.CreateDocument();
            excel.Open();
        }
    }
}
