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

        public string AddAtribute(string attribute, string value)
        {
            return String.Format(" {0}=\"{1}\"", attribute, value);
        }

        public string AddContent(string content)
        {
            return content;
        }

        public static string operator*(int n)
        {
        }
    }
}
