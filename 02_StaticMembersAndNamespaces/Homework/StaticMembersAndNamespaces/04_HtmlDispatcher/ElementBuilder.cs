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
        private Dictionary<string, string> attributes = new Dictionary<string,string>();
        private string content;

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

        public void AddAttribute(string attribute, string value)
        {
            this.attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.content = content;
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
            StringBuilder resultStr = new StringBuilder();
            string elementStartStr = "<" + this.ElementName;
            string elementEndStr = "</" + this.ElementName + ">";
            string elementAttributesAndValues = "";
            string contentStr = this.content;

            resultStr.Append(elementStartStr);

            foreach (var attribute in this.attributes)
            {
                elementAttributesAndValues += " ";
                elementAttributesAndValues += String.Format("{0}=\"{1}\"", attribute.Key, attribute.Value);
            }

            elementAttributesAndValues += ">";
            resultStr.Append(elementAttributesAndValues);
            resultStr.Append(contentStr);
            resultStr.Append(elementEndStr);
             
            return resultStr.ToString();
        }
    }
}
