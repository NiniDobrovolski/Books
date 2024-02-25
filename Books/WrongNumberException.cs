using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class WrongNumberException : ApplicationException
    {
        private string _msg;

        public WrongNumberException()
        {
            _msg = "Publication year must be integer number. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
