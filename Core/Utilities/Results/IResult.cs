using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    //sadece get; okunabilir demektir.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
