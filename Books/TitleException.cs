using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class TitleException : ApplicationException
    {
        private string _msg;

        public TitleException()
        {
            _msg = "Title must be valid. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
