using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Result
{
    public class ServiceResult<T>
    {
        public ServiceResult(bool status)
        {
            Status = status;
        }
        public ServiceResult(T data)
        {
            Data = data;
            Status = true;
        }
        public ServiceResult(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
