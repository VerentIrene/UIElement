using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UIElement
{
    class MyRegex : System.Text.RegularExpressions.Regex
    {
        public MyRegex(string pattern) { }
        public MyRegex(string pattern, RegexOptions options) { }
        public MyRegex(string pattern, RegexOptions options, TimeSpan matchTimeout) { }
        protected MyRegex() { }
        protected MyRegex(SerializationInfo info, StreamingContext context) { }

    }
}
