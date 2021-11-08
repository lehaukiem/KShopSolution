using System;
using System.Collections.Generic;
using System.Text;

namespace kShopSolution.Utilities.Exceptions
{
    public class KShopException : Exception
    {
        public KShopException()
        {
        }

        public KShopException(string message)
            : base(message)
        {
        }

        public KShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
