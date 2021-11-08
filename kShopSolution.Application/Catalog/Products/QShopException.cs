using System;
using System.Runtime.Serialization;

namespace kShopSolution.Application.Catalog.Products
{
    [Serializable]
    internal class QShopException : Exception
    {
        public QShopException()
        {
        }

        public QShopException(string message) : base(message)
        {
        }

        public QShopException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QShopException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}