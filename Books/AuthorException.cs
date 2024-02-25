using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class AuthorException : ApplicationException
    {
        private string _msg;

        public AuthorException()
        {
            _msg = "Author's name and lastname must be valid. Try again.";
        }
        public override string Message
        {
            get { return $"{_msg}"; }
        }
    }
}
