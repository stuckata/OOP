using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HtmlDispatcher
{
    class HtmlDispatcher
    {
        static void Main()
        {
            string inputТype = "";
            string name = "";
            string value = "";
            string url = "";
            string title = "";
            string text = "";
            string imageSource = "";
            string alt = "";
            string imgTitle = "";

            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 4);

            CreateImage(imageSource, alt, imgTitle);
            CreateURL(url, title, text);
            CreateInput(inputТype, name, value);
        }

        private static void CreateImage(string imageSource, string alt, string title)
        {
            throw new NotImplementedException();
        }

        private static void CreateURL(string url, string title, string text)
        {
            throw new NotImplementedException();
        }

        static void CreateInput(string inputТype, string name, string value)
        {

        }
    }
}
