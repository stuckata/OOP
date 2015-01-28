using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HtmlDispatcher
{
    public class ElementBuilder
    {
        private string elementName;
        private Dictionary<string, string> attributes;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName
        {
            get
            {
                return elementName;
            }
            set
            {
                elementName = value;
            }
        }

        public void AddAtribute(string attribute, string value)
        {
            attributes.Add(attribute, value);
        }

        public string AddContent(string content)
        {
            return content;
        }

        public static string operator *(ElementBuilder element, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
			{
                result += element.ToString();
			}
            return result;
        }

        public override string ToString()
        {
            return String.Format("");
        }
    }
}
