using System;
using System.Text;
using System.IO;

namespace Lab9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder html = new StringBuilder();
            string bodyOpen = "<body>\n";
            string bodyClose = "</body>\n";
            string headerOpen = "<h1>\n";
            string headerClose = "</h1>\n";
            string listOpen = "<ul>\n";
            string listClose = "</ul>\n";
            Console.WriteLine("Enter text for HTML header");
            string header = Console.ReadLine() + "\n";
            Console.WriteLine("Enter an item for the list");
            string listOne = "<li>" + Console.ReadLine() + "</li>\n";
            Console.WriteLine("Enter another item for the list");
            string listTwo = "<li>" + Console.ReadLine() + "</li>\n";
            Console.WriteLine("Enter another item for the list");
            string listThree = "<li>" + Console.ReadLine() + "</li>\n";

            html.Append(bodyOpen);
            html.Append(headerOpen);
            html.Append(header);
            html.Append(headerClose);
            html.Append(listOpen);
            html.Append(listOne);
            html.Append(listTwo);
            html.Append(listThree);
            html.Append(listClose);
            html.Append(bodyClose);

            string fileName = @"C:\Users\sk8er\Documents\Source\Lab9_4.html";
            File.WriteAllText(fileName, html.ToString());
        }
    }
}
