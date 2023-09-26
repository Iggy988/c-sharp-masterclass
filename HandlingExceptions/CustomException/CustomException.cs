using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions.CustomException;

[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get; }

    protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }

    public CustomException()
    {

    }

    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message, int statusCode, Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message) : base(message)
    {

    }

    public CustomException(string message, Exception innerException) : base(message, innerException)
    {

    }
}
