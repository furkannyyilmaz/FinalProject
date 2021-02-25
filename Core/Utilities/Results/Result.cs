using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //private bool v1;
        //private string v2;
                                                    // sen çalış ama alttaki constraucture ı da çalıştır.
        public Result(bool success, string message):this(success)
        {
            Message = message;
           //Success = success;

        }

        public Result(bool success)
        {
            //overload
            Success = success;
        }

        public bool Success { get; }

        public string Message { get;}
    }
}
