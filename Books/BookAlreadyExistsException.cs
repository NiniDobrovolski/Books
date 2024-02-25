using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class BookAlreadyExistsException : ApplicationException
    {
        private string _msg;

        public BookAlreadyExistsException()
        {
            _msg = "Book already exists. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
