using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatedMove
{
    class ErrorData
    {
        public Error error { get; set; }
    }
    public class Detail
    {
        public string target { get; set; }
        public string message { get; set; }
    }

    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<Detail> details { get; set; }
    }
}
