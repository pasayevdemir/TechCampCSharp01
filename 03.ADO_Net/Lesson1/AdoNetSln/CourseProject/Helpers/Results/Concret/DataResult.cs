using CourseProject.Helpers.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Helpers
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }

        public DataResult(bool isSuccess, string message, T data) 
            : base(isSuccess, message)
        {
            Data = data;
        }
    }
}
