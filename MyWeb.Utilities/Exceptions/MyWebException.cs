using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Utilities.Exceptions
{
    public class MyWebException : Exception
    {
        public MyWebException()
        {
        }

        public MyWebException(string message)
            : base(message)
        {
        }

        public MyWebException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
