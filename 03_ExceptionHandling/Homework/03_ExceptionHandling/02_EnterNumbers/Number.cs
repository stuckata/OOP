using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    public class Number
    {
        private string start;
        private string end;
        private string num;

        public string Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public string End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        public string Num
        {
            get
            {
                return this.num;
            }
            set
            {
                this.num = value;
            }
        }
    }
}
