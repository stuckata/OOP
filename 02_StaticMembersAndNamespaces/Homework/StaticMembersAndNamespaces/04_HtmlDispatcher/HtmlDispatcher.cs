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
            string inputТype = "submit";
            string name = "submitInput";
            string value = "Submit";
            string url = "http://www.w3schools.com";
            string title = "w3School";
            string text = "http://www.w3schools.com";
            string imageSource = "smiley.gif";
            string alt = "Smiley face";
            string imgTitle = "smileyFace";

            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 4);
            Console.WriteLine();

            CreateImage(imageSource, alt, imgTitle);
            CreateURL(url, title, text);
            CreateInput(inputТype, name, value);
        }

        private static void CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("src", imageSource);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);
            Console.WriteLine(img * 1);
            Console.WriteLine();
        }

        private static void CreateURL(string url, string title, string text)
        {
            ElementBuilder a = new ElementBuilder("a");
            a.AddAttribute("href", url);
            a.AddAttribute("title", title);
            a.AddContent(text);
            Console.WriteLine(a * 1);
            Console.WriteLine();
        }

        static void CreateInput(string inputТype, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", inputТype);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);
            Console.WriteLine(input * 1);
            Console.WriteLine();
        }
    }
}
